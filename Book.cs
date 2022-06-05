using System;

namespace projects {

    struct Book {

        private string title, avtor, into;

        public short pages;

        public void setValue(string title, string avtor) {
            this.title = title;
            this.avtor = avtor;
        }

        public void printValue() {
            System.Console.WriteLine(this.avtor + " написал книгу: <" + this.title + ">");
        }

    }

}