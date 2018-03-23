using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PropTh
{
    class Program
    {
        static void Main(string[] args)
        {
            Task919("919.txt");
            Task920("919.txt");
            Task921("919.txt");
            Task922("919.txt");
            Task923();
            Task924("924.txt");
            Task925();
            Task926();
            Console.ReadLine();

            /*
             * erf(1.82139) = 0.99 - Task 919, 920
             * erf(0.98) = 0.834232 - Task 921, 922
             * erf(0.95) = 0.820891 - Task 925
             */
        }

        static void Task919(string path)
        {
            Console.WriteLine("Task 919\n");
            SolvePth solution = new SolvePth();
            Dictionary<double, double> data = solution.readFile(path);

            Console.WriteLine("Overall: {0}", solution.overall);
            Console.WriteLine("Amount of cases: {0}", solution.amountOfCases);
            Console.WriteLine("Expected value: {0}", solution.Expected_Value(solution.amountOfCases));
            Console.WriteLine("Variance: {0}", solution.Variance(solution.amountOfCases));
            Console.WriteLine("S: {0}", solution.S(solution.amountOfCases));
            Console.WriteLine("Middle square error: {0}", solution.MiddleSquareError(solution.S(solution.amountOfCases), solution.amountOfCases, solution.overall));
            Console.WriteLine("Probability: {0}", solution.Erf(45 / solution.MiddleSquareError(solution.S(solution.amountOfCases), solution.amountOfCases, solution.overall)));

            double w = data.Values.Max() / solution.amountOfCases;
            Console.WriteLine("Middle square error for part: {0}", solution.MiddleSquareErrorPart(w, solution.amountOfCases, solution.overall));

            Console.WriteLine("Erf(t) = 0.99 -> t = 1.82139");
            double x = 1.82139 * solution.MiddleSquareErrorPart(w, solution.amountOfCases, solution.overall);
            Console.WriteLine("Delta: {0}", x);
            Console.WriteLine("Borders: [{0}; {1}]", w - x, w + x);
            Console.WriteLine();
        }

        static void Task920(string path)
        {
            Console.WriteLine("Task 920\n");
            SolvePth solution = new SolvePth();
            Dictionary<double, double> data = solution.readFile(path);
            int currentOverall = int.MaxValue;

            Console.WriteLine("Overall: INF ({0})", currentOverall);
            Console.WriteLine("Amount of cases: {0}", solution.amountOfCases);
            Console.WriteLine("Expected value: {0}", solution.Expected_Value(solution.amountOfCases));
            Console.WriteLine("Variance: {0}", solution.Variance(solution.amountOfCases));
            Console.WriteLine("S: {0}", solution.S(solution.amountOfCases));
            Console.WriteLine("Middle square error: {0}", solution.MiddleSquareError(solution.S(solution.amountOfCases), solution.amountOfCases, currentOverall));
            Console.WriteLine("Probability: {0}", solution.Erf(45 / solution.MiddleSquareError(solution.S(solution.amountOfCases), solution.amountOfCases, currentOverall)));

            double w = data.Values.Max() / solution.amountOfCases;
            Console.WriteLine("Middle square error for part: {0}", solution.MiddleSquareErrorPart(w, solution.amountOfCases, currentOverall));

            Console.WriteLine("Erf(t) = 0.99 -> t = 1.82139");
            double x = 1.82139 * solution.MiddleSquareErrorPart(w, solution.amountOfCases, currentOverall);
            Console.WriteLine("Delta: {0}", x);
            Console.WriteLine("Borders: [{0}; {1}]", w - x, w + x);
        }

        static void Task921(string path)
        {
            Console.WriteLine("Task 921\n");
            SolvePth solution = new SolvePth();
            Dictionary<double, double> data = solution.readFile(path);
            int currentCases = 58;

            Console.WriteLine("Overall: {0}", solution.overall);
            Console.WriteLine("Amount of cases: {0}", currentCases);
            Console.WriteLine("Expected value: {0}", solution.Expected_Value(currentCases));
            Console.WriteLine("Variance: {0}", solution.Variance(currentCases));
            Console.WriteLine("S: {0}", solution.S(solution.amountOfCases));
            Console.WriteLine("Middle square error: {0}", solution.MiddleSquareError(solution.S(currentCases), currentCases, solution.overall));
            Console.WriteLine("Probability: {0}", solution.Erf(0.01 / solution.MiddleSquareError(solution.S(currentCases), currentCases, solution.overall)));

            double w = data.Values.Max() / currentCases;
            Console.WriteLine("Middle square error for part: {0}", solution.MiddleSquareErrorPart(w, currentCases, solution.overall));

            Console.WriteLine("Erf(t) = 0.834232 -> t = 0.98");
            double x = 0.98 * solution.MiddleSquareErrorPart(w, currentCases, solution.overall);
            Console.WriteLine("Delta: {0}", x);
            Console.WriteLine("Borders: [{0}; {1}]", (w - x) / 10, (w + x) / 10);
            Console.WriteLine();
        }

        static void Task922(string path)
        {
            Console.WriteLine("Task 922\n");
            SolvePth solution = new SolvePth();
            Dictionary<double, double> data = solution.readFile(path);
            int currentCases = 58;
            int currentOverall = int.MaxValue;

            Console.WriteLine("Overall: INF ({0})", currentOverall);
            Console.WriteLine("Amount of cases: {0}", currentCases);
            Console.WriteLine("Expected value: {0}", solution.Expected_Value(currentCases));
            Console.WriteLine("Variance: {0}", solution.Variance(currentCases));
            Console.WriteLine("S: {0}", solution.S(solution.amountOfCases));
            Console.WriteLine("Middle square error: {0}", solution.MiddleSquareError(solution.S(currentCases), currentCases, currentOverall));
            Console.WriteLine("Probability: {0}", solution.Erf(0.01 / solution.MiddleSquareError(solution.S(currentCases), currentCases, currentOverall)));

            double w = data.Values.Max() / currentCases;
            Console.WriteLine("Middle square error for part: {0}", solution.MiddleSquareErrorPart(w, currentCases, currentOverall));

            Console.WriteLine("Erf(t) = 0.834232 -> t = 0.98");
            double x = 0.98 * solution.MiddleSquareErrorPart(w, currentCases, currentOverall);
            Console.WriteLine("Delta: {0}", x);
            Console.WriteLine("Borders: [{0}; {1}]", (w - x) / 10, (w + x) / 10);
            Console.WriteLine();
        }

        static void Task923()
        {
            Console.WriteLine("Task 923\n");
            SolvePth solution = new SolvePth();
            int currentOverall = 5000;
            int currentCases = 300;
            double expected = 8000;
            double middleSquareError = 2500;
            Console.WriteLine("Probability: {0}", solution.Erf(middleSquareError / expected));
            Console.WriteLine();
        }

        static void Task924(string path)
        {
            Console.WriteLine("Task 924\n");
            SolvePth solution = new SolvePth();
            Dictionary<double, double> data = solution.readFile(path);

            Console.WriteLine("Overall: {0}", solution.overall);
            Console.WriteLine("Amount of cases: {0}", solution.amountOfCases);
            Console.WriteLine("Expected value: {0}", solution.Expected_Value(solution.amountOfCases));
            Console.WriteLine("Variance: {0}", solution.Variance(solution.amountOfCases));
            Console.WriteLine("S: {0}", solution.S(solution.amountOfCases));
            Console.WriteLine("Middle square error: {0}", solution.MiddleSquareError(solution.S(solution.amountOfCases), solution.amountOfCases, solution.overall));
            Console.WriteLine("Probability: {0}", solution.Erf(0.01 / solution.MiddleSquareError(solution.S(solution.amountOfCases), solution.amountOfCases, solution.overall)));
            Console.WriteLine();
        }

        static void Task925()
        {
            Console.WriteLine("Task 925\n");
            SolvePth solution = new SolvePth();
            int currentOverall = 8000;
            int currentCases = 800;
            int fitting = currentCases * 9 / 10;
            Console.WriteLine("Middle square error for part: {0}", solution.MiddleSquareErrorPart(fitting, currentCases, currentOverall));
            double x = 0.95 * solution.MiddleSquareErrorPart(fitting, currentCases, currentOverall);
            Console.WriteLine("Delta: {0}", x);
            Console.WriteLine("Borders: [{0}; {1}]", (fitting - x)/1000, (fitting + x)/1000);
            Console.WriteLine();
        }
        
        static void Task926()
        {
            Console.WriteLine("Task 926\n");
            SolvePth solution = new SolvePth();

            int currentCases = 1500;
            int currentOverall = int.MaxValue;
            int good = currentCases * 3 / 10;
            Console.WriteLine("Middle square error for part: {0}", solution.MiddleSquareErrorPart(good, currentCases, currentOverall));
            double x = 0.95 * solution.MiddleSquareErrorPart(good, currentCases, currentOverall);
            Console.WriteLine("Delta: {0}", x);
            Console.WriteLine("Borders: [{0}; {1}]", (good - x) / 1000, (good + x) / 1000);
            Console.WriteLine();
        }
    }

    class SolvePth
    {
        public int overall { get; set; }
        public int amountOfCases { get; set; }
        Dictionary<double, double> data;
        public Dictionary<double, double> readFile(string path)
        {
            List<double> x = new List<double>();
            List<double> n = new List<double>();
            StreamReader file = new StreamReader(path);
            List<string> lines = new List<string>();
            data = new Dictionary<double, double>();
            string tempLine;

            while ((tempLine = file.ReadLine()) != null)
                lines.Add(tempLine);
            file.Close();

            string[] tempString = lines[0].Split();
            for (int i = 0; i < tempString.Length; ++i)
                x.Add(Convert.ToDouble(tempString[i]));

            tempString = lines[1].Split();
            for (int i = 0; i < tempString.Length; ++i)
                n.Add(Convert.ToDouble(tempString[i]));

            overall = Convert.ToInt32(lines[2]);

            for (int i = 0; i < x.Count; ++i)
                data.Add(x[i], n[i]);
            
            amountOfCases = 0;
            for (int i = 0; i < n.Count; ++i)
                amountOfCases += (int)n[i];
            return data;
        }

        public double Expected_Value(int cases)
        {
            double expected = 0;
            
            foreach (var item in data)
                expected += item.Key * item.Value / cases;
            return expected;
        }

        public double Arithmetic_Mean(int cases)
        {
                double mean = 0;
                foreach (var item in data)
                    mean += item.Key * item.Value;
                return mean /= cases;
        }

        public double Mode()
        {
            return data.FirstOrDefault(n => n.Value == data.Values.Max()).Key;
        }

        public double Median()
        {
            List<double> keys = new List<double>();
            foreach (var item in data)
                keys.Add(item.Key);
            keys.Sort();
            if ((keys.Count % 2) == 0)
                return (keys[(keys.Count / 2)] + keys[(keys.Count / 2) - 1]) / 2;
            else
                return keys[(keys.Count / 2) - 1];
        }

        public double Range()
        {
            return data.Keys.Max() - data.Keys.Min();
        }

        public double Variance(int cases)
        {
            double expected = Expected_Value(cases);
            double sum = 0;
            
            foreach (var item in data)
                sum += Math.Pow(item.Key, 2) * item.Value / cases;
            return sum - Math.Pow(expected, 2);
        }

        public double Standard_Deviation(int cases)
        {
            return Math.Sqrt(Variance(cases));
        }

        public double Coefficient_Of_Variation(Dictionary<double, double> data, int cases)
        {
            return Standard_Deviation(cases) / Expected_Value(cases);
        }

        public double Erf(double x)
        {
            //double result = 0;
            //for (int n = 0; n < k; ++n)
            //    result += Math.Pow(-1, n) * Math.Pow(x, (2 * n) + 1) / (Factorial(n) * (2 * n + 1));
            //return result *= (2 / Math.Sqrt(Math.PI));

            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;
            int sign = 1;
            if (x < 0)
                sign = -1;
            x = Math.Abs(x);
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);
            return sign * y;
        }

        public double S(int cases)
        {
            return Math.Sqrt(Math.Abs((cases * Variance(cases)  / (cases - 1))));
        }

        public double MiddleSquareError(double S, int n,  int N)
        {
            return Math.Sqrt(Math.Abs((S * (1 - n / N) / n)));
        }
        public double MiddleSquareErrorPart(double w, int n, int N)
        {
            return Math.Sqrt(Math.Abs((w * (1 - w) * (1 - n / N) / n)));
        }
    }
}