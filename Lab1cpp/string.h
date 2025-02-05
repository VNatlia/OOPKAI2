
#ifndef STRING_H
#define STRING_H

#include <string>

class String {
private:
    std:: string value; // �������� �����

public:
    // �����������
    String(const std::string& val);

    // ����� ��� ��������� ������� �����
    size_t getLength() const;

    // ����� ��� ��������� �����
    std::string reverseString() const;

    // ����� ��� ��������� �����
    std::string getValue() const;
};

#endif


