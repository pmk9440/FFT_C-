using System;

namespace FFTLibrary
{
    public class Complex
    {
        public double re, im;

        public Complex()
        {
            re = im = 0.0;
        }

        public Complex(double r, double i)
        {
            this.re = r;
            this.im = i;
        }

        public Complex Add(Complex z)
        {
            return new Complex(re + z.re, im + z.im);
        }

        public Complex Sub(Complex z)
        {
            return new Complex(re - z.re, im - z.im);
        }

        public Complex Mul(Complex z)
        {
            double r = re * z.re - im * z.im;
            double i = re * z.im + im * z.re;

            return new Complex(r, i);
        }

        public Complex Div(Complex z)
        {
            double d = z.re * z.re + z.im * z.im;
            double r = (re * z.re + im * z.im) / d;
            double i = (im * z.re - re * z.im) / d;

            return new Complex(r, i);
        }

        public static double Abs(Complex z)
        {
            return Math.Sqrt(z.re * z.re + z.im * z.im);
        }

        public static Complex Exp(Complex z)
        {
            double e = Math.Exp(z.re);
            double r = Math.Cos(z.im);
            double i = Math.Sin(z.im);

            return new Complex(e * r, e * i);
        }

        public static Complex[] RecursiveFFT(Complex[] a)
        {
            int n = a.Length;
            int n2 = n / 2;

            if (n == 1)
                return a;

            Complex z = new Complex(0.0, 2.0 * Math.PI / n);
            Complex omegaN = Complex.Exp(z);
            Complex omega = new Complex(1.0, 0.0);
            Complex[] a0 = new Complex[n2];
            Complex[] a1 = new Complex[n2];
            Complex[] y0 = new Complex[n2];
            Complex[] y1 = new Complex[n2];
            Complex[] y = new Complex[n];

            for (int i = 0; i < n2; i++)
            {
                a0[i] = new Complex(0.0, 0.0);
                a0[i] = a[2 * i];
                a1[i] = new Complex(0.0, 0.0);
                a1[i] = a[2 * i + 1];
            }

            y0 = RecursiveFFT(a0);
            y1 = RecursiveFFT(a1);

            for (int k = 0; k < n2; k++)
            {
                y[k] = new Complex(0.0, 0.0);
                y[k] = y0[k].Add(y1[k].Mul(omega));
                y[k + n2] = new Complex(0.0, 0.0);
                y[k + n2] = y0[k].Sub(y1[k].Mul(omega));
                omega = omega.Mul(omegaN);
            }

            return y;
        }

        public static double[] MakeFFT(int nCnt, double[] value)
        {
            int i;
            Complex[] a;
            Complex[] b;
            double[] result_fft;

            a = new Complex[nCnt];
            b = new Complex[nCnt];
            result_fft = new double[nCnt];

            try
            {
                for (i = 0; i < nCnt; i++)
                {
                    a[i] = new Complex(value[i], 0.0);
                }

                b = Complex.RecursiveFFT(a);

                for (i = 0; i < nCnt; i++)
                {
                    result_fft[i] = Math.Sqrt(b[i].re * b[i].re + b[i].im * b[i].im);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result_fft;
        }

        public static double[] RMS(double[] a)
        {
            double[] data_rms = new double[a.Length/2];
            double temp = new double();

            data_rms[0] = a[0]*1/Math.Sqrt(2);
            for (int i = 1; i < a.Length/2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    temp += a[j] * a[j];
                }
                data_rms[i] = Math.Sqrt(temp*2);
                temp = 0;
            }

            return data_rms;
        }

        public static double[] MakeRMS(int nCnt, double[] value)
        {
            double[] result_rms;
            double[] temp;

            result_rms = new double[nCnt];
            temp = new double[nCnt];

            try
            {
                temp = MakeFFT(nCnt, value);
                result_rms = Complex.RMS(temp);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result_rms;
        }

        public static int TransSize(int input_size)
        {
            int output_size = 0;
            double k;

            try
            {
                for (k = 0; k < 32; k++)
                {
                    if (Math.Pow(2.0, k) >= input_size)
                    {
                        output_size = (int)Math.Pow(2.0, k);
                        break;
                    }
                }
            }
            catch
            {

            }
            return output_size;
        }
    }
}