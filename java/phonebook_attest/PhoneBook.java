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
}
