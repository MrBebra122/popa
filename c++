#include <iostream>

int main() {
    const int rows = 3;
    const int columns = 5;

    double matrix[rows][columns];

    // Ввод элементов матрицы
    std::cout << "Введите элементы матрицы (3x5):\n";
    for (int i = 0; i < rows; ++i) {
        std::cout << "Строка (число + число) " << (i + 1) << ": ";
        for (int j = 0; j < columns; ++j) {
            std::cin >> matrix[i][j];
        }
    }

    // Вычисление среднего арифметического элементов строк
    for (int i = 0; i < rows; ++i) {
        double sum = 0.0;
        for (int j = 0; j < columns; ++j) {
            sum += matrix[i][j];
        }
        double average = sum / columns;
        std::cout << "Среднее арифметическое элементов строки " << (i + 1) << ": " << average << "\n";
    }

    return 0;
}
