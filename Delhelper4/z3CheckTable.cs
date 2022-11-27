class Check_table{
    Menu_all menu_All = new Menu_all();
    public void Table_Ticket_menu(Get_Set_ticket ticket){
        Console.WriteLine("_____________________________");
        Console.WriteLine("*Today's schedule*");              
        Console.WriteLine("*remaining seats Bangmod To Bangkhuntain {0}/25*",ticket.get_ticket_Mod_To_Khun());
        Console.WriteLine("*remaining seats Bangkhuntain To Bangmod {0}/25*",ticket.get_ticket_Khun_To_Mod());
        Console.WriteLine("*Check did you booking_______*");
        Console.WriteLine("-------------Menu-------------");
        Console.WriteLine("*Back pls input [anything]*");
        Console.WriteLine("______________________________");
        Console.ReadLine();
        Console.Clear();
        menu_All.PrintMainMenu(ticket);
    }
}