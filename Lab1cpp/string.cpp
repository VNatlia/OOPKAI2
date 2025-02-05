#include "string.h"
#include <algorithm>

// Конструктор
String::String (const std::string& val) : value(val) {}

// Метод для отримання довжини рядка
size_t String::getLength() const {
    return value.length();
}

// Метод для обернення рядка
std::string String::reverseString() const {
    std::string reversed = value;
    std::reverse(reversed.begin(), reversed.end());
    return reversed;
}

// Метод для отримання рядка
std::string String::getValue() const {
    return value;
}
