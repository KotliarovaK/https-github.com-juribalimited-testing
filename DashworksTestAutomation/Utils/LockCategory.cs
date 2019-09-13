﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Utils
{
    class LockCategory
    {
        private static List<List<string>> _testsTags;
        private static readonly Mutex _mutex = new Mutex();

        static LockCategory()
        {
            _testsTags = new List<List<string>>();
        }

        private static bool IsTagExistInCurrentSession(string expectedTag)
        {
            var text = string.Empty;
            foreach (List<string> list in _testsTags)
            {
                text += String.Join(", ", list.ToArray()) + "\r\n";
            }

            var result = _testsTags.Any(x => x.Any(y => y.Contains(expectedTag)));

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
            foreach (List<string> tagsList in _testsTags)
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
            if (_testsTags.Any())
            {
                //If test contains tag that depends on other tags
                if (categories.Any(x => x.Contains("Do_Not_Run_With")))
                {
                    var lockTag = categories.First(x => x.Contains("Do_Not_Run_With"))
                        .Replace("Do_Not_Run_With_", string.Empty);
                    //Check that there is no tests with mentioned tag
                    if (IsTagExistInCurrentSession(lockTag))
                    {
                        while (IsTagExistInCurrentSession(lockTag) && _testsTags.Any())
                        {
                            Thread.Sleep(2000);
                            Logger.Write("1. Tag exists in the context");
                        }
                    }
                }

                //If test contains tag with which we can't run
                if (IsTagExistInCurrentSession("Do_Not_Run_With"))
                {
                    while (GetDoNotRunWithTags().Intersect(categories).Any() && _testsTags.Any())
                    {
                        Thread.Sleep(2000);
                        Logger.Write("2. Do_Not_Run_With in the context");
                    }
                }
            }
        }

        public static void AddTags(List<string> tags)
        {
            _mutex.WaitOne();

            try
            {
                //After adding mutex we can probable should remove lock
                lock (_testsTags)
                {
                    _testsTags.Add(tags);
                }
            }
            finally
            {
                _mutex.ReleaseMutex();
            }
        }

        public static void RemoveTags(List<string> tags)
        {
            _mutex.WaitOne();

            try
            {
                //After adding mutex we can probable should remove lock
                lock (_testsTags)
                {
                    if (_testsTags.Any())
                    {
                        var index = -1;
                        for (int i = 0; i < _testsTags.Count; i++)
                        {
                            if (_testsTags[i].SequenceEqual(tags))
                            {
                                index = i;
                                break;
                            }
                        }

                        if (index >= 0)
                            _testsTags.RemoveAt(index);
                    }
                }
            }
            //Remove all tags in case of any errors!
            catch (Exception e)
            {
                Logger.Write($"ERROR REMOVING TAGS: {e}");
                //_testsTags = new List<List<string>>();
            }
            finally
            {
                _mutex.ReleaseMutex();
            }
        }
    }
}
