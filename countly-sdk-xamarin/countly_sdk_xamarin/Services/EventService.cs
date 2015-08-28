using System;
using System.Collections.Generic;
using System.Diagnostics;
using countly_sdk_xamarin.Models;

namespace countly_sdk_xamarin.Services
{
    class EventService
    {
        private EventService()
        {
            this.count = 0;
            EventQueue = new Queue<Event>();
        }

        private static EventService instance;
        public static EventService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EventService();
                }
                return instance;
            }
        }

        private Queue<Event> EventQueue;
        private int eventCount;
        
        public int EventCount
        {
            get { return eventCount; }
        }
        
        public Queue<Event> GetEvents (int count)
        {
            Debug.Assert(count > this.eventCount);
            if (count > this.eventCount) return null;
            this.eventCount -= count;

            Queue<Event> pushReq = new Queue<Event>();
            for (int i = 0; i < count; i++)
            {
                pushReq.Enqueue(EventQueue.Dequeue());
            }
            return pushReq;
        }

        public void AddEvent(string Key) //count defaults to 1 internally
        {
            Event newEvent = new Event()
            {
                key = Key,
                count = 1
            };
            EventQueue.Enqueue(newEvent);
            eventCount++;
        }

        public void AddEvent(string Key, int Count)
        {
            Event newEvent = new Event()
            {
                key = Key,
                count = Count
            };
            EventQueue.Enqueue(newEvent);
            eventCount++;
        }

        public void AddEvent(string Key, double Sum) //count defaults to 1 internally
        {
            Event newEvent = new Event()
            {
                key = Key,
                count = 1,
                sum = Sum
            };
            EventQueue.Enqueue(newEvent);
            eventCount++;
        }

        public void AddEvent(string Key, Dictionary<String, String> Segmentation) //count defaults to 1 internally
        {
            Event newEvent = new Event()
            {
                key = Key,
                count = 1,
                segmentation = Segmentation
            };
            EventQueue.Enqueue(newEvent);
            eventCount++;
        }

        public void AddEvent(string Key, int Count, double Sum)
        {
            Event newEvent = new Event()
            {
                key = Key,
                count = Count,
                sum = Sum
            };
            EventQueue.Enqueue(newEvent);
            eventCount++;
        }

        public void AddEvent(string Key, int Count, Dictionary<String, String> Segmentation)
        {
            Event newEvent = new Event()
            {
                key = Key,
                count = Count,
                segmentation = Segmentation
            };
            EventQueue.Enqueue(newEvent);
            eventCount++;
        }

        public void AddEvent(string Key, int Count, double Sum, Dictionary<String, String> Segmentation)
        {
            Event newEvent = new Event()
            {
                key = Key,
                count = Count,
                sum = Sum,
                segmentation = Segmentation
            };
            EventQueue.Enqueue(newEvent);
            eventCount++;
        }

        // custom method
        //public void AddEvent(Event eventToAdd)
        //{
        //    eventCount++;
        //    EventQueue.Enqueue(eventToAdd);
        //}
    }
}
