using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson8_Task6_TininA
{
    public class Adapter
    {
        private IView view;
        private Serializator srl;

        public Adapter(IView view)
        {
            this.view = view;
            srl = new Serializator();
        }

        public void ToXML()
        {
            srl.Serialize(view.CSVFilename,view.XMLFilename,WaysOfSerialize.FromCSV_ToXML);
        }

        public void ToCSV()
        {
            srl.Serialize(view.CSVFilename, view.XMLFilename, WaysOfSerialize.FromXML_ToCSV);
        }
    }
}
