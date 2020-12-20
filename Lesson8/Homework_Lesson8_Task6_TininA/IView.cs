using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson8_Task6_TininA
{
    public interface IView
    {
        string XMLFilename { get; }
        string CSVFilename { get; }
    }
}
