#include "mainwindow.h"

#include <QApplication>
#include <QLabel>

int main(int argc, char *argv[])
{
    QApplication app(argc, argv);
    QLabel label("Hello world !");
    label.setStyleSheet("QLabel:hover { color: rgb(255, 255, 113)}");
    label.show();
   return app.exec();
}
