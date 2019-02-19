using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheetMusicGenerator.Domain.Model;

namespace SheetMusicGenerator.Domain.Pitch
{
    public class Pitchshifter
    {
        /// <summary>
        /// Notes goes from A to G
        /// </summary>
        /// <param name="direction">+ or -</param>
        /// <param name="sheet">Model</param>
        public void ShiftPitch(string direction, Sheet sheet)
        {   
            foreach (var sheetBar in sheet.Bars)
            {
                foreach (var sheetBarNode in sheetBar.Nodes)
                {
                    var isUpper = char.IsUpper(sheetBarNode.Value, 0);
                    var charNode = (int)sheetBarNode.Value.ToCharArray()[0];

                    if (direction.Equals("+"))
                    {
                        if (sheetBarNode.Value.ToLower().Equals("g"))
                        {
                            sheetBarNode.Value = isUpper ? "A" : "a";
                        }
                        else
                        {
                            charNode = charNode + 1;
                            sheetBarNode.Value = char.ConvertFromUtf32(charNode);
                        }                       
                    }
                    else //assume "-"
                    {
                        if (sheetBarNode.Value.ToLower().Equals("a"))
                        {
                            sheetBarNode.Value = isUpper ? "G" : "g";
                        }
                        else
                        {
                            charNode = charNode - 1;
                            sheetBarNode.Value = char.ConvertFromUtf32(charNode);
                        }
                    }
                }
            }
        }
    }
}
