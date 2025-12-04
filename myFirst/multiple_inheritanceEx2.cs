using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    public interface IPhone
    {
        void MakeCall(string number, int duration);
        void SendSMS(string number, string message);
    }

    public interface ICamera
    {
        void TakePhoto(string mode, int resolution);
        void RecordVideo(string format, int duration);
    }
    public class SmartDevice : IPhone, ICamera
    {
        public void MakeCall(string number, int duration)
        {
            Console.WriteLine($"Calling {number} for {duration} minutes..");

        }
        public void SendSMS(string number, string message)
        {
            Console.WriteLine($"Sending SMS to {number}: {message}");
        }
        public void TakePhoto(string mode, int resolution)
        {
            Console.WriteLine($"Taking a {mode} photo at {resolution} MP resolution...");
        }
       public void RecordVideo(string format, int duration)
        {
            Console.WriteLine($"Recording a {format} video for {duration} minutes...");
        }


    }
    internal class multiple_inheritanceEx2
    {
        static void Main(string[] args)
        {
           
            SmartDevice s = new SmartDevice();
            s.MakeCall("9302291876",5);
            s.SendSMS("9478781726","Hello!");

            s.TakePhoto("Potrait",12);
            s.RecordVideo("MP4",10);

            Console.WriteLine("----Multiple Inheritance Example 2-----");
            Console.ReadLine();
        }
    }
}
