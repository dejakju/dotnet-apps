namespace libs
{
    static class Program
    {
        static int Main()
        {
            SingleLinkedList sll = new();

            sll.insert(1);
            sll.insert(2);
            sll.insert(3);
            sll.insert(4);
            sll.insert(5);

            for (int i = 1; i <= sll.length(); i++)
                System.Console.WriteLine($"Item #{i}: {sll.get_data(i)}");
            System.Console.WriteLine($"Total = {sll.length()}; is_empty = {sll.is_empty()}; is_full = {sll.is_full()}\n");

            sll.insert_at(1, "Loverman");
            sll.insert_at(3, "Lipe cvatu");
            sll.insert_at(5, "White rabbit");
            sll.insert_at(7, "Perfect Gentleman");

            for (int i = 1; i <= sll.length(); i++)
                System.Console.WriteLine($"Item #{i}: {sll.get_data(i)}");
            System.Console.WriteLine($"Total = {sll.length()}; is_empty = {sll.is_empty()}; is_full = {sll.is_full()}\n");

            System.Console.WriteLine($"object removed_at(7) = {sll.remove_at(7)}");
            System.Console.WriteLine($"object removed_at(5) = {sll.remove_at(5)}");
            System.Console.WriteLine($"object removed_at(3) = {sll.remove_at(3)}");
            System.Console.WriteLine($"object removed_at(1) = {sll.remove_at(1)}\n");

            for (int i = 1; i <= sll.length(); i++)
                System.Console.WriteLine($"Item #{i}: {sll.get_data(i)}");

            sll.add_tail("Hi, i'm the new TAIL");
            sll.add_head("Hi, i'm the new HEAD!");

            for (int i = 1; i <= sll.length(); i++)
                System.Console.WriteLine($"Item #{i}: {sll.get_data(i)}");

            sll.rem_head();
            sll.rem_tail();
            sll.replace(5, "Goran");
            sll.replace(3, 3.141592);

            for (int i = 1; i <= sll.length(); i++)
                System.Console.WriteLine($"Item #{i}: {sll.get_data(i)}");
            System.Console.WriteLine($"Total = {sll.length()}; is_empty = {sll.is_empty()}; is_full = {sll.is_full()}\n");

            System.Console.WriteLine($"Is 'Goran' in the list? Answer: {sll.contains("Goran")}");
            System.Console.WriteLine($"Is 'Boogeyman' in the list? Answer: {sll.contains("Boogeyman")}");
            System.Console.WriteLine($"Is Pi in the list? Answer: {sll.contains(3.141592)}");

            System.Console.WriteLine($"Clearing list..."); sll.clear();
            System.Console.WriteLine($"Total = {sll.length()}; is_empty = {sll.is_empty()}; is_full = {sll.is_full()}");

            return 0;
        }
    }
}