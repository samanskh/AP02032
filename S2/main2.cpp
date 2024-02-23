#include<iostream>

using namespace std;

class str
{
    int size;
    char* s;
public:
    str():s(NULL),size(0)
    {
    }
    str(const char* x ):size(0)
    {
        int count = 0;
        const char* ptr = x; 
        while (*ptr != 0) {
        count++;
        ptr++;
        }
        size = count;
        s = (char*)malloc(size * sizeof(char));
        for (int i = 0 ; i<size;i++)
        s[i] = x[i];
    }

str(const str& s1) : size(s1.size) {
    s = (char*)malloc((size) * sizeof(char));
    for (int i = 0; i < size; ++i) {
        s[i] = s1.s[i];
    }
    s[size] = 0;
}

    ~str()
    {
        if (s != NULL)
            free(s);
    }
    int len() const
    {
        return size;
    }

    void append(const char* pch){
        int count = 0;
        while (*pch)
        {
            count++;
            pch++;
        }
        int newsize = count+size+1;
        char* nchar = (char*)malloc((newsize)*sizeof(char));
        for (int i=0;i<size;i++)
        nchar[i]=s[i];
        for (int j=size;j<newsize;j++)
        nchar[j]=pch[j-size];
        free(s);
        s = nchar;
        size = newsize;
    }

    void append(const str& s1)
    {
        int count = s1.size;
        int newsize = count+size+1;
        char* nchar = (char*)malloc((newsize)*sizeof(char));
        for (int i=0;i<size;i++)
        nchar[i]=s[i];
        for (int j=size;j<newsize;j++)
        nchar[j]=s1.s[j-size];
        nchar[newsize-1]=0;
        s = nchar;
        size = newsize;
        free(nchar);
    }

    void print() const
    {
        for (int i = 0; i < size;i++)
        {
            cout << s[i];
            }
        cout << endl;
    }

    void replace(char c1, char c2){
        for (int i=0;i<size;i++)
        {
            if (s[i] == c1)
            s[i] = c2;
        }
    }

    str substr(int start, int count) const
    {
        char* temp = (char*)malloc(sizeof(char)*count);
        for (int i = 0 ; i<count;i++)
            temp[i] = s[start + i];
        temp[start+count] = 0;
        str out(temp);
        free(temp);
        return out;
    }

    void remove(int start, int count)
    {
        char* nchar = (char*)malloc((size-count+1)*sizeof(char));
        for (int i=0;i<start;i++)
            nchar[i] = s[i];

        for (int j = start+count;j<size;j++)
            nchar[j-count] = s[j];
            
        nchar[size-count]=0;    
        
        for (int i = 0; i<size-count;i++)
            s[i] = nchar[i];
        
        size -= count;
        free(nchar);    
    }

    str reverse() const
    {
        char* nchar = (char*)malloc((size)*sizeof(char));
        for (int i = 0;i<size;i++)
        nchar[size-i-1] = s[i];
        nchar[size] = 0;
        str out(nchar);
        return out;
    }

    char get_char(int loc)
    {
        return s[loc];
    }

    const char* chars() const
    {
        return s; 
    }
};

int main()
{
    str s1("saman");
    s1.print();
    str s2(s1);
    s2.print();
    int len_test = s1.len();
    cout << len_test << endl;
    len_test = s2.len();
    cout << len_test << endl;
    s1.append("kh");
    s1.print();
    s2.append(s1);
    s2.print();
    s1.replace('s','S');
    s1.print();
    str s3("khajeamiri");
    s3.remove(2,4);
    s3.print();
    str s7("khajeamiri");
    str s4 = s7.substr(2,4);
    s4.print();
    str s5("saman khajeamiri");
    str s6 = s5.reverse();
    s6.print();

    return 0;
}