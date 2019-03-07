namespace LabFiveA {

    public class Node {
        public int value;
        public Node next;

        public Node(int value) {
            this.value = value;
        }

    }

    public class NcLinkedList {
        private Node head;

        public NcLinkedList() {
            head = new Node(0);
        }

        public void addToEnd(Node node) {

            var toAdd = new Node(0);
            
            while(node.next != null) {
                toAdd = node.next;
            }

            toAdd.next = node;
        }

    }
}