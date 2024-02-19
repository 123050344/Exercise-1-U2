
namespace Exercise_1_U2
{
    class program
    {

        static void Main(string[] args)
        {
            formula velo = new formula();
            velo.v_carro(1000,600,1.6667);

            Console.WriteLine("~The speed of a car~");
            Console.WriteLine("Distance(m)= " + velo.Distance);
            Console.WriteLine("time(s)= " + velo.Time);
            Console.WriteLine("velocity=" + velo.Velocity + "m/s");
            Console.ReadLine();
        }
    }

}