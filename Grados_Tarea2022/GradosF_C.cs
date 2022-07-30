using System;
using System.Collections.Generic;
using System.Text;

namespace Grados_Tarea2022
{
    class GradosF_C : IGradosFC
    {
        public double GradosFt_Cs { set; get; }

        public GradosF_C()
        {
        }

        public GradosF_C(double gradosF_C)
        {
            GradosFt_Cs = gradosF_C;
        }
        public double CalcularGradosF_C()
        {
            return (GradosFt_Cs - 32) * 0.5556; 
        }
    }
}
