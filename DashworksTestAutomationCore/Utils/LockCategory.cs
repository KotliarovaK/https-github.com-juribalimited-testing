using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using RestSharp;

namespace DashworksTestAutomation.Utils
{
    class LockCategory
    {
        static readonly RestClient client = new RestClient(JuribaAutomationApiProvider.Uri);

        //private static List<List<string>> _testsTags;
        //private static readonly Mutex _mutex = new Mutex();

        static LockCategory()
        {
            //_testsTags = new List<List<string>>();
        }

        private static bool IsTagExistInCurrentSession(string expectedTag)
        {
            var text = string.Empty;
            var testsTags = GetTags();
            foreach (List<string> list in testsTags)
            {
                text += String.Join(", ", list.ToArray()) + "\r\n";
            }

            var result = testsTags.Any(x => x.Any(y => y.Contains(expectedTag)));

            if (result)
            {
                Logger.Write("=======>");
                Logger.Write($"TAG '{expectedTag}' is in the list:");
                Logger.Write(text);
                Logger.Write("<=======");
            }
            return result;
        }

        private static List<string> GetDoNotRunWithTags()
        {
            List<string> doNotRunWithTag = new List<string>();
            var tags = GetTags();
            foreach (List<string> tagsList in tags)
            {
                foreach (string s in tagsList)
                {
                    if (s.Contains("Do_Not_Run_With"))
                        doNotRunWithTag.Add(s.Replace("Do_Not_Run_With_", string.Empty));
                }
            }

            return doNotRunWithTag;
        }

        public static void AwaitTags(List<string> categories)
        {
            if (GetTags().Any())
            {
                //If test contains tag that depends on other tags
                if (categories.Any(x => x.Contains("Do_Not_Run_With")))
                {
                    var lockTags = categories.Where(x => x.Contains("Do_Not_Run_With_"))
                        .Select(x => x.Replace("Do_Not_Run_With_", string.Empty));
                    //Check that there is no tests with mentioned tag
                    if (lockTags != null && lockTags.Any() && lockTags.Any(IsTagExistInCurrentSession))
                    {
                        while (GetTags().Any() && lockTags.Any(IsTagExistInCurrentSession))
                        {
                            Thread.Sleep(5000);
                            Logger.Write("1. Tag exists in the context");
                        }
                    }
                }

                //If test contains tag with which we can't run
                if (IsTagExistInCurrentSession("Do_Not_Run_With"))
                {
                    while (GetDoNotRunWithTags().Intersect(categories).Any() && GetTags().Any())
                    {
                        Thread.Sleep(5000);
                        Logger.Write("2. Do_Not_Run_With in the context");
                    }
                }
            }
        }

        //public static void AddTags(List<string> tags)
        //{
        //    _mutex.WaitOne();

        //    try
        //    {
        //        //After adding mutex we can probable remove lock
        //        lock (_testsTags)
        //        {
        //            _testsTags.Add(tags);
        //        }
        //    }
        //    finally
        //    {
        //        _mutex.ReleaseMutex();
        //    }
        //}

        //public static void RemoveTags(List<string> tags)
        //{
        //    _mutex.WaitOne();

        //    try
        //    {
        //        //After adding mutex we can probable should remove lock
        //        lock (_testsTags)
        //        {
        //            if (_testsTags.Any())
        //            {
        //                var index = -1;
        //                for (int i = 0; i < _testsTags.Count; i++)
        //                {
        //                    if (_testsTags[i].SequenceEqual(tags))
        //                    {
        //                        index = i;
        //                        break;
        //                    }
        //                }

        //                if (index >= 0)
        //                    _testsTags.RemoveAt(index);
        //            }
        //        }
        //    }
        //    //Remove all tags in case of any errors!
        //    catch (Exception e)
        //    {
        //        Logger.Write($"ERROR REMOVING TAGS: {e}");
        //        //_testsTags = new List<List<string>>();
        //    }
        //    finally
        //    {
        //        _mutex.ReleaseMutex();
        //    }
        //}

        public static void RemoveTestTags(string testName)
        {
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    var request = new RestRequest($"tags/{testName}", Method.DELETE);
                    IRestResponse response = client.Execute(request);
                    if (response.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        return;
                    }
                }
                catch
                {
                    Thread.Sleep(2000);
                }
            }

            throw new Exception("Unable to get tags from API");
        }

        private static List<List<string>> GetTags()
        {
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    var request = new RestRequest("tags", Method.GET);
                    IRestResponse response = client.Execute(request);
                    var tags = JsonConvert.DeserializeObject<List<List<string>>>(response.Content);
                    return tags;
                }
                catch
                {
                    Thread.Sleep(2000);
                }
            }

            throw new Exception("Unable to get tags from API");
        }

        public static void AddTags(string testName, List<string> tags)
        {
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    var request = new RestRequest("tags", Method.POST);
                    request.AddHeader("Accept", "application/json");
                    request.AddJsonBody(new { Name = testName, AddingTime = DateTime.UtcNow, Tags = tags });
                    IRestResponse response = client.Execute(request);
                    if (response.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        return;
                    }
                }
                catch
                {
                    Thread.Sleep(2000);
                }
            }

            throw new Exception("Unable to get tags from API");
        }
    }
}
