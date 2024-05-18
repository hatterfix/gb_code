import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;

public class PhoneBook {
    // Храним контакты в виде "Имя" -> "Номера телефонов"
    private Map<String, Set<String>> contacts = new HashMap<>();

    // Добавляет контакт в телефонную книгу
    public void addContact(String name, String phone) {
        // Метод computeIfAbsent добавляет контакт или обновляет существующие
        // добавляет номер телефона к имени существующего контакта
        contacts.computeIfAbsent(name, k -> new HashSet<>()).add(phone);
    }

    // Выводим контакты на экран, по убыванию количества номеров
    public void displayContacts() {
        // Преобразуем записи из телефонной книге в поток, затем сортируем
        contacts.entrySet().stream()
                .sorted((e1, e2) -> Integer.compare(e2.getValue().size(), e1.getValue().size()))
                .forEach(entry -> System.out.println(entry.getKey() + ": " + entry.getValue()));
        
        System.out.println("Total contacts: " + contacts.size());
    }
    
    // Демонстрация работы 
    public static void main(String[] args) {
        // Экземпляр класса PhoneBook
        PhoneBook phoneBook = new PhoneBook();

        // Формирую книгу
        phoneBook.addContact("Alice", "71112223344");
        phoneBook.addContact("Alice", "71112223345");
        phoneBook.addContact("Andy", "72223334455");
        phoneBook.addContact("Andy", "72223334456");
        phoneBook.addContact("Andy", "72223334457");
        phoneBook.addContact("Kate", "73334445566");

        // Вывод на экран
        phoneBook.displayContacts();
    }
}
