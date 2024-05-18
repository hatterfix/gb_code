import java.util.*;

public class PhoneBook {
    // Храним контакты в виде "Имя" -> "Номера телефонов"
    private Map<String, Set<String>> contacts = new HashMap<>();

    // Добавляет контакт в телефонную книгу
    public void addContact(String name, String phone) {
        // Метод computeIfAbsent добавляет контакт или обновляет существующие
        // добавляет номер телефона к имени сузествующего контакта
        contacts.computeIfAbsent(name, k -> new HashSet<>()).add(phone);
    }

    // Выводим контакты на экран, по убыванию количества номеров
    public void displayContacts() {
        // Преобразуем записи в  телефонной книге в поток , затем сортируем
        contacts.entrySet().stream()
                .sorted((e1, e2) -> Integer.compare(e2.getValue().size(), e1.getValue().size()))
                .forEach(entry -> System.out.println(entry.getKey() + ": " + entry.getValue()));
    }
}
