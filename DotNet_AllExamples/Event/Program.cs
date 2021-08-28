using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {

            BusinessProccessLogic businessProccessLogic = new BusinessProccessLogic();
            businessProccessLogic.ProccessCompleted += (sender, e) =>
            {
                Console.WriteLine($"Event Raised. argument value is {e}");
            };

            businessProccessLogic.ProccessCompleted += (sender, e) =>
            {
                Console.WriteLine($"Event Raised 2222222. argument value is {e}");
            };
            businessProccessLogic.ProccessCompleted += (sender, e) =>
            {
                Console.WriteLine($"Event Raised 3333333. argument value is {e}");
            };

            businessProccessLogic.StartProccess();

        }
    }

    public class BusinessProccessLogic
    {
        public event EventHandler<bool> ProccessCompleted;

        public void StartProccess()
        {
            try
            {
                Console.WriteLine("Businsss Proccess Started");
                OnProccessCompleted(true);

            }
            catch (Exception)
            {
                OnProccessCompleted(false);
                throw;
            }
        }


        protected virtual void OnProccessCompleted(bool isOk)
        {
            ProccessCompleted?.Invoke(this, isOk);
        }
    }
}
