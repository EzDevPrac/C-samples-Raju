using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
  public  class House
    {
        private string foundation;
        private string structure;
        private string roof;
        private bool furnished;
        private bool painted;
        public void SetFoundation(string foundation)
        {
            this.foundation = foundation;
        }
        public void SetStructure(string structure)
        {
            this.structure = structure;
        }
        public void SetRoof(string roof)
        {
            this.roof = roof;
        }
        public void SetFurnished(bool furnished)
        {
            this.furnished = furnished;
        }
        public void SetPainted(bool painted)
        {
            this.painted = painted;
        }

        public string toString()
        {
            return "Foundation - " + foundation + " Structure - " + structure + " Roof - " + roof + " Is Furnished? " + furnished + " Is Painted? " + painted;
        }
    }
}
