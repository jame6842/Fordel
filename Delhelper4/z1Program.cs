class Program
{
    static void Main(string[] args)
    {
        Menu_all menu_All = new Menu_all();
        Booking_Menu booking_Menu = new Booking_Menu();
        Get_Set_ticket ticket = new Get_Set_ticket();
        menu_All.PrintMainMenu(ticket);
    }
}