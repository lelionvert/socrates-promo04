using System;

namespace SocratesFr.ColdMealManagement
{
    public interface IKitchen
    {
        bool HasColdMealAvailableAt(DateTime dateTime);
    }
}