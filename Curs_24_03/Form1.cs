using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Curs_24_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextReader load = new StreamReader(@"../../TextFile1.txt");
            int n = int.Parse(load.ReadLine());
            int[] v = new int[n]; //asa declaram vectorul
            for (int i = 0; i < n - 5; i++)
            {
                v[i] = int.Parse(load.ReadLine());
            }
            string buffer = load.ReadLine();
            string[] t = buffer.Split(' ');
            for (int i = n -5 ; i < n; i++)
            {
                v[i] = int.Parse(t[i - n + 5]); //asa am citit vectorul cand ultimele elementele erau pe aceiasi linie
            }
            string toV = "";
            for (int i = 0; i < n; i++)
                toV += v[i] + " ";
            listBox1.Items.Add(toV);
            /*for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(v[i]+ " "); //in loc de consolewriteline scriu asta ca sa afisez in listbox
            }*/
            #region bubblesortV1
            /*bool ok;
            int aux;
            do
            {
                ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = false;
                    }
                }
            }
            while (!ok);*/
            #endregion
            #region BubbleSortV2 
            /*//am tinut cont de maximul ajunge pe ultima pozitie la fiecare etapa
            bool ok;
            int aux;
            int k = 0;
            do
            {
                ok = true;
                for (int i = 0; i < n - 1 - k; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = false;
                    }
                }
                k++;
            }            
            while (!ok);*/
            #endregion

            #region SelectionSort 
            /*//selectez minimul/maxim si il pun pe prima pozitie
            int aux;
            for (int j = 0; j < n -1; j++)
            {
                int poz = j;
                int min = v[j];
                for (int i = 1 + j; i < n; i++)
                {
                    if (v[i] < min)
                    {
                        min = v[i];
                        poz = i;
                    }                   
                }
                aux = v[j];
                v[j] = v[poz];
                v[poz] = aux;
            }*/
            #endregion
            #region ForInFor(sau Intershimbare)
            int aux;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
            #endregion
            toV = "";
            for (int i = 0; i < n; i++)           
                toV += v[i] + " ";
            listBox1.Items.Add(toV); //am pus vectorul intr-un string si l-am afisat cu listbox

    
            
        }
        //form1Designer - de acolo stergi erorile cand stergi un listbox
        //https://en.wikipedia.org/wiki/Sorting_algorithm
    }
}
