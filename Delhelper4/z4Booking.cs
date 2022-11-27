class Booking_Menu{
    static Menu_all menu_All = new Menu_all();
    private string booking_check;
    private void set_booking_check(){
        this.booking_check = Console.ReadLine();
    }
    //----------------------------------------------------------------------------------
    public void Book_Menu(Get_Set_ticket ticket){
        Console.WriteLine("______________________________");
        Console.WriteLine("*-Time*");              //ตารางเวลา----
        Console.WriteLine("*--------Book_Ticket---------*");
        Console.WriteLine("*1.KMUTT --> Bang Khun Thian *");
        Console.WriteLine("*2.Bang Khun Thian --> KMUTT *");
        Console.WriteLine("*3.Back to Bus Ticket Booking*");
        Console.WriteLine("______________________________");
        Console.Write("Please input Menu:");
        set_booking_check();
        switch(booking_check) 
        {
            case "1":
                Console.Clear();
                Menu_Mod_To_Khun(ticket);
                break;
            case "2":
                Console.Clear();
                Menu_Khun_To_Mod(ticket);
                break;
            case "3":
                Console.Clear();
                menu_All.PrintMainMenu(ticket);
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                Console.Clear();
                Book_Menu(ticket);
                break;
        }
    }
    //--------------------------------------------------------------------------------
    public void Menu_Khun_To_Mod(Get_Set_ticket ticket){
        Console.Clear();      
        Console.WriteLine("______________________________");
        Console.WriteLine("*Time----*");
        Console.WriteLine("*remaining seats {0}/25*",ticket.get_ticket_Khun_To_Mod());
        Console.WriteLine("*--------Book_Ticket----------*");
        Console.WriteLine("*--KMUTT --> Bang Khun Thian--*");
        Console.WriteLine("*Get Ticket please input [Y]");
        Console.WriteLine("*Back please input [?]*");
        Console.WriteLine("______________________________");
        Console.Write("Please in put here : ");
        ticket.set_Khun_To_Mod();
        set_booking_check();
        switch(booking_check){
            case "Y":
                ticket.increase_ticket();
                break;
            case "y":
                ticket.increase_ticket();
                break;
            case "C":
                ticket.decrease_ticket();
                break;
            case "c":
                ticket.decrease_ticket();
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                break;
        }
    Console.Clear();
    Book_Menu(ticket);
    }
    public void Menu_Mod_To_Khun(Get_Set_ticket ticket){
        Console.Clear();      
        Console.WriteLine("______________________________");
        Console.WriteLine("*Time----*");
        Console.WriteLine("*remaining seats {0}/25*",ticket.get_ticket_Mod_To_Khun());
        Console.WriteLine("*--------Book_Ticket----------*");
        Console.WriteLine("*--KMUTT --> Bang Khun Thian--*");
        Console.WriteLine("*Get Ticket please input [Y]");
        Console.WriteLine("*Back please input [?]*");
        Console.WriteLine("______________________________");
        Console.Write("Please in put here : ");
        ticket.set_Mod_To_Khun();
        set_booking_check();
        switch(booking_check){
            case "Y":
                ticket.increase_ticket();
                break;
            case "y":
                ticket.increase_ticket();
                break;
            case "C":
                ticket.decrease_ticket();
                break;
            case "c":
                ticket.decrease_ticket();
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                break;
        }
    Console.Clear();
    Book_Menu(ticket);
    }
}