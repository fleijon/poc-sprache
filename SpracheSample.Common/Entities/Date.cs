using System;

namespace SpracheSample.Common
{
    public class Date : Literal<DateTime>
    {
        public Date(DateTime date) : base(date)
        {
        }
    }
}