namespace Jump_İnterpolation_SearchAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs for Interpolation Search Algorithm 
            int[] arr = { 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 13, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 15, 16, 17, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 19, 19, 20, 20, 21 };
            int a = 12;  //the element we are looking for

            Console.WriteLine("InterpolationSearchAlgorithm's Result: ");
            SearchAlgorithms.InterpolationSearchAlgorithm(arr, a);



            //inputs for Jump Search Algorithm
            int[] arrr = { 0, 0, 2, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };
            int b = 33;   //the element we are looking for

            Console.WriteLine("\nJumpSearchAlgorithm's Result: ");
            SearchAlgorithms.JumpSearchAlgorithm(arrr, b);

        }
    }
}