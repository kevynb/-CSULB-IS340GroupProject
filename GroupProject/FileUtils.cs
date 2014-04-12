using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GroupProject
{
    public class FileUtils
    {
        public static XmlReader OpenXmlFileWithDialog(string title = null)
        {
            var dialog = new OpenFileDialog {DefaultExt = "xml", Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"};
            if (title != null)
                dialog.Title = title;
            XmlReader reader = null;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileToOpen = dialog.FileName;
                reader = XmlReader.Create(fileToOpen);
            }
            return reader;
        }
    }
}