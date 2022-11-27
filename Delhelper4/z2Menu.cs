class Menu_all{
    static Booking_Menu booking_Menu = new Booking_Menu();
    static Check_table check_Table = new Check_table();
    private int Menu_check=0;

    public void set_menucheck(){
        int check;
        int.TryParse(Console.ReadLine(),out check);
        this.Menu_check = check;
    }
    private void reset_Menu_check(){
        this.Menu_check =0;
    }

    public void PrintMainMenu(Get_Set_ticket ticket) {
        Console.WriteLine("______________________________");
        Console.WriteLine("------Bus Ticket Booking----------");
        Console.WriteLine("1.Checking"); //ตารางเวลาวันนี้ รอบรถที่ จำนวนที่นั่ง  ?/25<0-24>  
        Console.WriteLine("2.Booking");  //แสดงรอบรถปัจจุบัน จำนวนที่นั่ง  errorจากเเอด   เลือกให้จอด
        Console.WriteLine("4.Logout");
        Console.WriteLine("______________________________");
        Console.Write("Please input Menu:");
        set_menucheck();
        switch(Menu_check) 
        {
            case 1:
                Console.Clear();
                check_Table.Table_Ticket_menu(ticket);
                break;
            case 2:
                Console.Clear();        
                booking_Menu.Book_Menu(ticket);
                break;
            case 3:
                break;
            case 4:
                break;
            default: 
                Console.WriteLine("You in put wrong. \nPlease Try Again");
                Console.ReadLine();
                Console.Clear();
                PrintMainMenu(ticket);
                break;
        }
    }
}