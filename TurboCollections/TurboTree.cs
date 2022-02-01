namespace TurboCollections;

public class TurboTree{
    int[] tree;
    int[] leftTree;
    int[] rightTree;
    int _base;

    void Insert(int insertedNumber,int[] tree){
        if (_base == null){
            this.tree[0] = insertedNumber;
            return;
        }

        if (_base!= null){
            if (insertedNumber>_base){
                Insert(insertedNumber,rightTree);
            }
            else{
                Insert(insertedNumber,leftTree);
            }
        }
    }
}