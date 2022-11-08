using System;

namespace Factory_example
{
    public static class Creator
    {

        public static HomePge Create(string type)
        {
            switch (type)
            {
                case "Customer":
                    {
                        return new Customer();
                    };
                case "Admin":
                    {
                        return new Admin();
                        break;
                    };
                default:
                    {
                        throw new NullReferenceException();
                    }
            }
        }
    }
}
