using System;

namespace SpracheSample.Common
{
    public class ElisaDate : Literal<DateTime>
    {
        public ElisaDate(DateTime date) : base(date)
        {
        }
    }
}