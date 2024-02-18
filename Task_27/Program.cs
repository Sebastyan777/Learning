namespace Task_27
{
    internal class Program {}

    public interface Isend
    {
        void Send();
    }

    public class Email : Isend
    {
        public void Send() {}
    }

    public class Sms : Isend 
    { 
        public void Send() {} 
    }

    public class Notificator
    {
        private Isend _isend;

        public void Notify()
        {
            _isend.Send();
        }
    }
}
