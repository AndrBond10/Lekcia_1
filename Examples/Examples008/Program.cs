int Nax(int ag1, int ag2, int ag3)
{
    int result = ag1;
    if (ag2 > result) result = ag2;
    if (ag3 > result) result = ag3;
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int mx1 = Nax(a1, b1, c1);
int mx2 = Nax(a2, b2, c2);
int mx3 = Nax(a3, b3, c3);
int mx = Nax(mx1, mx2, mx3);
Console.WriteLine(mx);