using System.ComponentModel.Design;

namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0)) {
                answer = true;
            }
            else
            {
                answer = false;
            }
                // code here

                // end

                return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;
            if (a == 0)
            {
                if (a % b == 0)
                {
                    answer = true;
                }
            }
            else if (b == 0)
            {
                if(b % a == 0)
                {
                    answer = true;
                }
            }
            else
            {
                if ((a % b == 0 ) || (b % a == 0))
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }

            }
            


            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if ((a == Math.Pow(b, 2)) | a == Math.Pow(b, 3) | b == Math.Pow(a, 2) || b == Math.Pow(a, 3))
            {
                answer = true;
            }
            // code here

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            answer = Math.Pow(f, 2) - 4 * d * g;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1){
                answer = 1;
            }
            else if (x  > -1 && x <= 1)
            {
                answer = -1 * x;
            }
            else if (x > 1)
            {
                answer = -1;
            }
                // code here

                // end

                return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;
            double d = Math.Pow(2 * squareS, 0.5);
            double r = (circleS / double.Pi);
            r = Math.Sqrt(r);
            if (d  < 2 * r){
                answer = true;
            }

            // code here

            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            if (s)
            {
                if (t)
                {
                    answer = 6;
                }
                else if ( t == false)
                {
                    if (f){
                        answer = 10;
                    }
                    else if(f == false)
                    {
                        answer = 2;
                    }
                }
            }
            else
            {
                if (t)
                {
                    answer = 3;
                }
                else if (t == false)
                {
                    if (f == true)
                    {
                        answer = 5;
                    }
                    if (f == false)
                    {
                        answer = 1;
                    }
                }
            }
                // code here

                // end

                return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;
            int av = ((pupils - 1) / 7) + 1;
            int cost = (av * salary) + (5 * pupils);

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
                answer = false;
            }
            else
            {
                if (cost <= bank)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
                
            }
            
            return answer;
        }
    }
}