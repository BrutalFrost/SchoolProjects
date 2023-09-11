
class BankUser {
    private static int balance;
    private static string name;
    public BankUser (string newName) {
        name = newName;
        balance = 500;
    }
    
    public void SetBalance (int addAmount) {
        
        balance = balance + addAmount;
        
        return;
    }

    public int GetBalance () {
        return balance;
    }
    public string GetName () {
        return name;
    }
}