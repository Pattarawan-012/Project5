using System;

namespace CompletHomework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Image data address : ");
            string inputFileimage = Console.ReadLine();
            // C:\Users\milky\Desktop\input.txt

            
            double[,] ImageDataInputFile = ReadImageDataFromFile(inputFileimage);
            // C:\Users\milky\Desktop\Convolution.txt

            Console.Write("Input ConvolutionKernel address : ");
            string DataFileConvolutionKernel = Console.ReadLine();
            // C:\Users\milky\Desktop\Output.txt

            
            double[,] imageDataConvolution = ReadImageDataFromFile(DataFileConvolutionKernel);

            Console.Write("Output address : ");
            string DataFileOutput = Console.ReadLine(); 

            
            double[,] RepeatedTextureArray = new double[7, 7];
           
            for (int i = 0; i <= 6; i++)
            {
                int newi = ((i - 1) + 5) % 5;
                for (int j = 0; j <= 6; j++)
                {
                    int newj = ((j - 1) + 5) % 5;
                    RepeatedTextureArray[i, j] = ImageDataInputFile[newi, newj];
                    Console.Write("{0}  ", ImageDataInputFile[newi, newj]);
                }
                Console.WriteLine();
            }

            
            double[,] ConvolutionKernelArray = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ConvolutionKernelArray[i, j] = imageDataConvolution[i, j];
                }
                Console.WriteLine();
            }

            
            Console.WriteLine("Convolve");
            double[,] DataFileOutputArray = Convolution(RepeatedTextureArray, ConvolutionKernelArray);

            
            WriteImageDataToFile(DataFileOutput, DataFileOutputArray);
        
        }

        static double[,] Convolution(double[,] TextureArray, double[,] convolutionKernelArray)
        {
            double[,] FileOutputArray = new double[5, 5];
            for (int i = 0; i < 5; i++)
            {
                int RepeatedRowOne = i * 1; int RepeatedRowTwo = i + 1; int RepeatedRowThree = i + 2;
                for (int j = 0; j < 5; j++)
                {
                    int RepeatedColumnOne = j * 1; int RepeatedColumnTwo = j + 1; int repeated_column3 = j + 2;
                    FileOutputArray[i, j] = (TextureArray[RepeatedRowOne, RepeatedColumnOne] * convolutionKernelArray[0, 0])
                        + (TextureArray[RepeatedRowOne, RepeatedColumnTwo] * convolutionKernelArray[0, 1]) 
                        + (TextureArray[RepeatedRowOne, repeated_column3] * convolutionKernelArray[0, 2])
                        + (TextureArray[RepeatedRowTwo, RepeatedColumnOne] * convolutionKernelArray[1, 0]) 
                        + (TextureArray[RepeatedRowTwo, RepeatedColumnTwo] * convolutionKernelArray[1, 1]) 
                        + (TextureArray[RepeatedRowTwo, repeated_column3] * convolutionKernelArray[1, 2])
                        + (TextureArray[RepeatedRowThree, RepeatedColumnOne] * convolutionKernelArray[2, 0]) 
                        + (TextureArray[RepeatedRowThree, RepeatedColumnTwo] * convolutionKernelArray[2, 1]) 
                        + (TextureArray[RepeatedRowThree, repeated_column3] * convolutionKernelArray[2, 2]);
                    Console.Write("{0}", FileOutputArray[i, j]);
                }
                Console.WriteLine();
            }
            return FileOutputArray;
        }


        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }


        static void WriteImageDataToFile(string imageDataFilePath,
                                         double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);

            Console.ReadLine();
        }

     

    }
}
