using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_09
{
    class Uravnenie
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        private static int counter = 0;

        public Uravnenie(double ka, double kb, double kc)
        {
            A = ka;
            B = kb;
            C = kc;
            counter++;
        }

        public static int GetCounter()
        {
            return counter;
        }

        public double[] Solution()
        {
            double D = B * B - 4 * A * C;
            if (D < 0)
            {
                return null;
            }
            else
            {
                if (D == 0)
                {
                    double[] res = { (-B + Math.Sqrt(D)) / 2 / A };
                    return res;
                }
                else if (A != 0)
                {
                    double[] res = { (-B + Math.Sqrt(D)) / 2 / A, (-B - Math.Sqrt(D)) / 2 / A };
                    return res;
                }
                else
                {
                    if (B != 0)
                    {
                        double[] res = { -C / B };
                        return res;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static double[] Solution(double ka, double kb, double kc)
        {
            double D = kb * kb - 4 * ka * kc;
            if (D < 0)
            {
                return null;
            }
            else
            {
                if (D == 0)
                {
                    double[] res = { (-kb + Math.Sqrt(D)) / 2 / ka };
                    return res;
                }
                else if (ka != 0)
                {
                    double[] res = { (-kb + Math.Sqrt(D)) / 2 / ka, (-kb - Math.Sqrt(D)) / 2 / ka };
                    return res;
                }
                else
                {
                    if (kb != 0)
                    {
                        double[] res = { -kc / kb };
                        return res;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public override string ToString()
        {
            string res = "";
            if (A != 0)
            {
                res += $"{A}x^2";
            }

            if (B < 0)
            {
                res += $"{B}x";
            }
            else if (B != 0)
            {
                res += $"+{B}x";
            }

            if (C < 0)
            {
                res += $"{B}";
            }
            else if (C != 0)
            {
                res += $"+{C}";
            }

            res += "=0";
            return res;
        }

        public static Uravnenie operator ++(Uravnenie ur)
        {
            ur.A++;
            ur.B++;
            ur.C++;
            return ur;
        }

        public static Uravnenie operator --(Uravnenie ur)
        {
            ur.A--;
            ur.B--;
            ur.C--;
            return ur;
        }

        public static explicit operator double(Uravnenie ur)
        {
            double[] sol = ur.Solution();
            if (sol != null)
            {
                return sol[0];
            }
            else
            {
                return 0;
            }
        }

        public static implicit operator bool(Uravnenie ur)
        {
            double[] sol = ur.Solution();
            return sol != null;
        }

        public static bool operator ==(Uravnenie ur1, Uravnenie ur2)
        {
            return ur1.A == ur2.A && ur1.B == ur2.B && ur1.C == ur2.C;
        }

        public static bool operator !=(Uravnenie ur1, Uravnenie ur2)
        {
            return ur1.A != ur2.A && ur1.B != ur2.B && ur1.C != ur2.C;
        }
    }
}
