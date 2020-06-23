#include <iostream>
using namespace std;

int main(int argc, char* argv[]) {
	char contra[10];
	int numeros = 48, minus = 65, mayus = 97;
	int a, b, c, d, e, f, g, h, i, j;
	a = b = c = d = e = f = g = h = i = j = 48;

	int cont = 1;

	while (cont <= 62)
	{
		contra[0] = a;
		contra[1] = b;
		contra[2] = c;
		contra[3] = d;
		contra[4] = e;
		contra[5] = f;
		contra[6] = g;
		contra[7] = h;
		contra[8] = i;
		contra[9] = j;
		for (int i = 0; i < 10; i++)
		{
			cout << contra[i];
		}cout << endl;
		if (a == 57)
		{
			a = 64;
		}

		if (a == 90)
		{
			a = 96;
		}
		a++;
		if (a == 123)
		{
			if (b == 57)
			{
				b = 64;
			}

			if (b == 90)
			{
				b = 96;
			}
			a = 48;
			b++;

			if (b == 123)
			{
				if (c == 57)
				{
					c = 64;
				}

				if (c == 90)
				{
					c = 96;
				}
				a = 48;
				b = 48;
				c++;
				if (c == 123)
				{
					if (d == 57)
					{
						d = 64;
					}

					if (d == 90)
					{
						d = 96;
					}
					a = 48;
					b = 48;
					c = 48;
					d++;
					if (d == 123)
					{
						if (e == 57)
						{
							e = 64;
						}

						if (e == 90)
						{
							e = 96;
						}
						a = 48;
						b = 48;
						c = 48;
						d = 48;
						e++;
						if (e == 123)
						{
							if (f == 57)
							{
								f = 64;
							}

							if (f == 90)
							{
								f = 96;
							}
							a = 48;
							b = 48;
							c = 48;
							d = 48;
							e = 48;
							f++;
							if (f == 123)
							{
								if (g == 57)
								{
									g = 64;
								}

								if (g == 90)
								{
									g = 96;
								}
								a = 48;
								b = 48;
								c = 48;
								d = 48;
								e = 48;
								f = 48;
								g++;
								if (g == 123)
								{
									if (h == 57)
									{
										h = 64;
									}

									if (h == 90)
									{
										h = 96;
									}
									a = 48;
									b = 48;
									c = 48;
									d = 48;
									e = 48;
									f = 48;
									g = 48;
									h++;
									if (h == 123)
									{
										if (i == 57)
										{
											i = 64;
										}

										if (i == 90)
										{
											i = 96;
										}
										a = 48;
										b = 48;
										c = 48;
										d = 48;
										e = 48;
										f = 48;
										g = 48;
										h = 48;
										i++;
										if (i == 123)
										{
											if (j == 57)
											{
												j = 64;
											}

											if (j == 90)
											{
												j = 96;
											}
											a = 48;
											b = 48;
											c = 48;
											d = 48;
											e = 48;
											f = 48;
											g = 48;
											h = 48;
											i = 48;
											j++;
											cont++;
										}
									}
								}
							}
						}
					}
				}
			}
		}


	}





	system("pause");
	return 0;
}