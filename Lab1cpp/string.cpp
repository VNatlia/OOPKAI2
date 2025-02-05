#include "string.h"
#include <algorithm>

// �����������
String::String (const std::string& val) : value(val) {}

// ����� ��� ��������� ������� �����
size_t String::getLength() const {
    return value.length();
}

// ����� ��� ��������� �����
std::string String::reverseString() const {
    std::string reversed = value;
    std::reverse(reversed.begin(), reversed.end());
    return reversed;
}

// ����� ��� ��������� �����
std::string String::getValue() const {
    return value;
}
