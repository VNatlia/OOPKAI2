#include <iostream>
#include "string.h"

int main() {
    std::string userInput;
    std::cout << "Введіть рядок: ";
    std::getline(std::cin, userInput);

    // Створення об'єкта класу
    String myString(userInput);

    // Виведення початкового рядка
    std::cout << "Рядок: " << myString.getValue() << std::endl;

    // Виведення довжини рядка
    std::cout << "Довжина рядка: " << myString.getLength() << std::endl;

    // Виведення оберненого рядка
    std::cout << "Обернений рядок: " << myString.reverseString() << std::endl;

    return 0;
}

