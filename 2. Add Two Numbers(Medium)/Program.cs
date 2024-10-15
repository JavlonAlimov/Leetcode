


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int value = 0, ListNode nextNode = null)
    {
        val = value;
        next = nextNode;
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        // Yangi ro'yxat uchun "dummy" boshlang'ich tugun yaratamiz
        ListNode dummyHead = new ListNode();
        ListNode current = dummyHead;
        int carry = 0; // Ko'tarish (agar qo'shish natijasida >9 bo'lsa)

        // Ikkala ro'yxatni ham boshidan oxirigacha yuramiz
        while (l1 != null || l2 != null || carry != 0)
        {
            // l1 va l2 ning qiymatlari, agar ro'yxat tugagan bo'lsa 0 deb olinadi
            int val1 = (l1 != null) ? l1.val : 0;
            int val2 = (l2 != null) ? l2.val : 0;

            // Ikkita qiymatni va ko'tarishni qo'shamiz
            int sum = val1 + val2 + carry;
            carry = sum / 10; // Ko'tarishni hisoblaymiz
            int newValue = sum % 10; // Yangi qiymat (qo'shilgan natija)

            // Yangi tugunni ro'yxatga qo'shamiz
            current.next = new ListNode(newValue);
            current = current.next;

            // Keyingi tugunga o'tamiz
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        // Yangi ro'yxatning boshidagi tugunni qaytaramiz
        return dummyHead.next;
    }
}

