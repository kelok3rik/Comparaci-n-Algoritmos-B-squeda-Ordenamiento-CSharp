using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimularCarreras
{
    public partial class Form1 : Form
    {

        // Generar un nuevo arreglo aleatorio
        int[] arreglo;


        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtBoxBuscar.Text == "" || arregloTxt.Text == "")
            {
                MessageBox.Show("INGRESE UN VALOR"); return;
            }

            int valorBuscar = Convert.ToInt32(txtBoxBuscar.Text);

            arreglo = arregloTxt.Text.Split(',').Select(int.Parse).ToArray();


            Console.WriteLine("Arreglo con el que se trabaja: " + string.Join(", ", arreglo));

            // Crear tareas para ejecutar cada algoritmo simultáneamente

            Task tareaInsercion = Task.Run(() =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                Insercion(arreglo);
                TiempoInsercion = sw.Elapsed;
                Console.WriteLine("Arreglo ordenado por inserción: " + string.Join(", ", arreglo));
            });

            Task<int> tareaBusquedaSecuencial = Task.Run(() =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                int resultado = BusquedaSecuencial(arreglo, valorBuscar);
                TiempoBusquedaSecuencial = sw.Elapsed;
                return resultado;
            });

            Task<int> tareaBusquedaBinaria = Task.Run(() =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                int resultado = BusquedaBinaria(arreglo, valorBuscar);
                TiempoBusquedaBinaria = sw.Elapsed;
                return resultado;
            });

            Task tareaBurbuja = Task.Run(() =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                Burbuja(arreglo);
                TiempoBurbuja = sw.Elapsed;
            });

            Task tareaQuickSort = Task.Run(() =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                QuickSort(arreglo, 0, arreglo.Length - 1);
                TiempoQuickSort = sw.Elapsed;
            });



            // Obtener la memoria consumida por el proceso
            long memoriaConsumida = Process.GetCurrentProcess().PrivateMemorySize64;
            labelMemoriaConsumida.Text = $"Memoria consumida: {memoriaConsumida / 1024 / 1024} MB";




            // Inicializa las variables para guardar los tiempos más rápidos
            string algoritmoBusquedaMasRapido = "";
            TimeSpan tiempoBusquedaMasRapido = TimeSpan.MaxValue;
            string algoritmoOrdenamientoMasRapido = "";
            TimeSpan tiempoOrdenamientoMasRapido = TimeSpan.MaxValue;

            // Después de que todas las tareas estén completas, mostrar resultados
            Task.WhenAll(tareaBusquedaSecuencial, tareaBusquedaBinaria, tareaBurbuja, tareaQuickSort, tareaInsercion)
                .ContinueWith((task) =>
                {


                    // Mostrar los tiempos de ejecución de cada algoritmo
                    this.Invoke((Action)(() =>
                    {
                        labelTiempoSecuencial.Text = $"Tiempo de Búsqueda Secuencial: {TiempoBusquedaSecuencial}";
                        labelTiempoBinario.Text = $"Tiempo de Búsqueda Binaria: {TiempoBusquedaBinaria}";
                        labelTiempoBurbuja.Text = $"Tiempo de Ordenamiento Burbuja: {TiempoBurbuja}";
                        labelTiempoQuickSort.Text = $"Tiempo de Quick Sort: {TiempoQuickSort}";
                        labelMetodoInsercion.Text = $"Tiempo de Método de Inserción: {TiempoInsercion}";
                    }));




                    // Compara y actualiza los tiempos más rápidos para la búsqueda
                    if (TiempoBusquedaSecuencial < tiempoBusquedaMasRapido)
                    {
                        algoritmoBusquedaMasRapido = "Búsqueda Secuencial";
                        tiempoBusquedaMasRapido = TiempoBusquedaSecuencial;
                    }

                    if (TiempoBusquedaBinaria < tiempoBusquedaMasRapido)
                    {
                        algoritmoBusquedaMasRapido = "Búsqueda Binaria";
                        tiempoBusquedaMasRapido = TiempoBusquedaBinaria;
                    }

                    // Compara y actualiza los tiempos más rápidos para el ordenamiento
                    if (TiempoBurbuja < tiempoOrdenamientoMasRapido)
                    {
                        algoritmoOrdenamientoMasRapido = "Ordenamiento Burbuja";
                        tiempoOrdenamientoMasRapido = TiempoBurbuja;
                    }

                    if (TiempoQuickSort < tiempoOrdenamientoMasRapido)
                    {
                        algoritmoOrdenamientoMasRapido = "Quick Sort";
                        tiempoOrdenamientoMasRapido = TiempoQuickSort;
                    }

                    if (TiempoInsercion < tiempoOrdenamientoMasRapido)
                    {
                        algoritmoOrdenamientoMasRapido = "Método de Inserción";
                        tiempoOrdenamientoMasRapido = TiempoInsercion;
                    }

                    this.Invoke((Action)(() =>
                    {
                        labelResultadoCarrera.Text = $"El ganador de la carrera fue {algoritmoBusquedaMasRapido} con un tiempo de ejecución de {tiempoBusquedaMasRapido}";
                        labelResultadoCarreraOrd.Text = $"El ganador de la carrera fue {algoritmoOrdenamientoMasRapido} con un tiempo de ejecución de {tiempoOrdenamientoMasRapido}";
                    }));

                });




        }

        // Variables para almacenar los tiempos de ejecución de los algoritmos
        TimeSpan TiempoBusquedaSecuencial;
        TimeSpan TiempoBusquedaBinaria;
        TimeSpan TiempoBurbuja;
        TimeSpan TiempoQuickSort;
        TimeSpan TiempoInsercion;

        static int[] GenerarArregloAleatorio(int tamano)
        {
            Random rnd = new Random();
            int[] arreglo = new int[tamano];
            for (int i = 0; i < tamano; i++)
            {
                arreglo[i] = rnd.Next(0, 10000); // Números aleatorios del 0 al 999
            }
            return arreglo;

        }

        // Implementación de los algoritmos de búsqueda y ordenamiento

        static int BusquedaSecuencial(int[] arreglo, int valor)
        {
            Console.WriteLine("Busqueda secuencial a buscar: " + valor);
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valor)
                {
                    return i;
                }
            }
            return -1;
        }

        static int BusquedaBinaria(int[] arreglo, int valor)
        {
        
            int inicio = 0;
            int fin = arreglo.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                if (arreglo[medio] == valor)
                {
                    return medio;
                }
                else if (arreglo[medio] < valor)
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }

            return -1;
        }

        static void Burbuja(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                for (int j = 0; j < arreglo.Length - 1 - i; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }

        }

        static void QuickSort(int[] arreglo, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int indiceParticion = Particionar(arreglo, izquierda, derecha);

                QuickSort(arreglo, izquierda, indiceParticion - 1);
                QuickSort(arreglo, indiceParticion + 1, derecha);
            }
        }

        static int Particionar(int[] arreglo, int izquierda, int derecha)
        {
            int pivote = arreglo[derecha];
            int indiceMenor = izquierda - 1;

            for (int j = izquierda; j < derecha; j++)
            {
                if (arreglo[j] <= pivote)
                {
                    indiceMenor++;
                    int temp = arreglo[indiceMenor];
                    arreglo[indiceMenor] = arreglo[j];
                    arreglo[j] = temp;
                }
            }

            int temp1 = arreglo[indiceMenor + 1];
            arreglo[indiceMenor + 1] = arreglo[derecha];
            arreglo[derecha] = temp1;

            return indiceMenor + 1;
        }

        static void Insercion(int[] arreglo)
        {
            for (int i = 1; i < arreglo.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arreglo[j] < arreglo[j - 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j - 1];
                        arreglo[j - 1] = temp;
                    }
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            arreglo = GenerarArregloAleatorio(10000);

            // Mostrar el arreglo en el TextBox
            arregloTxt.Text = string.Join(", ", arreglo);
        }
    }
}