
#ifndef STRING_H
#define STRING_H

#include <string>

class String {
private:
    std:: string value; // Значення рядка

public:
    // Конструктор
    String(const std::string& val);

    // Метод для отримання довжини рядка
    size_t getLength() const;

    // Метод для обернення рядка
    std::string reverseString() const;

    // Метод для отримання рядка
    std::string getValue() const;
};

#endif


