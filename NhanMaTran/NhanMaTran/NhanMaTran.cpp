#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>  
#include<conio.h>  
#include <malloc.h>
#include <string>
using namespace std;
//cấp phát bộ nhớ đọng cho ma trận 2 chiều -tạo ra ma trận 2 chiều động sử dụng malloc
int** CapPhatMaTran(int dong, int cot) {
	int** a;
	a = (int**)malloc(dong * sizeof(int*));
	for (int i = 0; i < dong; i++)
	{
		// Cấp phát cho từng con trỏ cấp 1 
		a[i] = (int*)malloc(cot * sizeof(int));
	}
	return a;
}

int** NhapMaTran(int dong, int cot)
{
	int** a = CapPhatMaTran(dong, cot);//tạo ra ma trận
	for (int i = 0; i < dong; i++)//nhập giá trị từng phần tử của ma trận
		for (int j = 0; j < cot; j++)
		{
			printf("a[%d][%d] = ", i, j);
			scanf("%d", &a[i][j]);//gán giá trị dc nhập từ bàn phím vào trong mảng
		}
	return a;
}

void XuatMaTran(int** a, int dong, int cot)
{
	for (int i = 0; i < dong; i++)
	{
		for (int j = 0; j < cot; j++)
			printf("%5d", a[i][j]);
		printf("\n");
	}
}
void GiaiPhongBoNho(int** a, int dong) {
	for (int i = 0; i < dong; i++)
	{
		free(a[i]);
	}
	free(a);
}

void GhiFile(FILE* fp, int** a, int m, int n) {
	for (int i = 0; i < m; i++) {
		for (int j = 0; j < n; j++) {
			fprintf(fp, "%20d\t", a[i][j]);
		}
		fprintf(fp, "\n");
	}
}

int main()
{
	int** a, ** b, hang1, cot1, hang2, cot2;
	int** matrantong = NULL;
	int** matrantich = NULL;
	bool tong = false, tich = false;

	printf("Nhap so hang cua ma tran 1: ");
	scanf("%d", &hang1);
	printf("\nNhap so cot cua ma tran 1: ");
	scanf("%d", &cot1);

	a = NhapMaTran(hang1, cot1);

	printf("Nhap so hang cua ma tran 2: ");
	scanf("%d", &hang2);

	printf("\nNhap so cot cua ma tran 2: ");
	scanf("%d", &cot2);

	b = NhapMaTran(hang2, cot2);
	//m1n1*m2n2 thì n1=m2
	//cootj1  bằng hang 2
	printf("\ntinh tong 2 ma tran");
	if (cot1 != cot2 || hang1 != hang2) {
		printf("\nKhong the tinh tong 2 ma tran do hang va cot 2 ma tran khac nhau a[%d,%d]!=b[%d,%d]", hang1, cot1, hang2, cot2);
	}
	else
	{
		tong = true;
		matrantong = CapPhatMaTran(hang1, cot1);
		for (int i = 0; i < hang1; i++)
		{
			for (int j = 0; j < cot1; j++)
			{
				matrantong[i][j] = a[i][j] + b[i][j];
			}
		}
		printf("\nTinh xong tong 2 ma tran");
	}
	// ma  trận tích có số hàng = số côt =
	printf("\nTinh tich 2 ma tran");
	if (cot1 != hang2)
		printf("\nKhong the nhan 2 ma tran do cot ma tran 1=&%d khac hang ma tran 2=%d", cot1, hang2);
	else
	{
		matrantich = CapPhatMaTran(hang1, cot2);
		tich = true;
		for (int i = 0; i < hang1; i++)
		{
			for (int j = 0; j < cot2; j++)
			{
				matrantich[i][j] = 0;
				for (int k = 0; k < cot1; k++)
				{
					matrantich[i][j] += a[i][k] * b[k][j];
				}
			}
		}
		printf("\nTinh xong tich 2 ma tran");
	}

	printf("\nin ca ma tran");
	printf("\nma tran a: \n");
	XuatMaTran(a, hang1, cot1);
	printf("\nma tran b: \n");
	XuatMaTran(b, hang2, cot2);
	if (tong)
	{
		printf("\nma tran tong: \n");
		XuatMaTran(matrantong, hang1, cot1);
	}
	if (tich)
	{
		printf("\nma tran tich: \n");
		XuatMaTran(matrantich, hang1, cot2);
	}
	printf("\nGhi file: ");
	FILE* fp;
	fp = fopen("mang.txt", "w");
	fprintf(fp, "%s\n", "ma tran a");
	GhiFile(fp, a, hang1, cot1);
	fprintf(fp, "%s\n", "ma tran b");
	GhiFile(fp, b, hang2, cot2);
	if (tong)
	{
		fprintf(fp, "%s\n", "ma tran tong");
		GhiFile(fp, matrantong, hang1, cot1);
	}
	if (tich)
	{
		fprintf(fp, "%s\n", "ma tran tich");
		GhiFile(fp, matrantich, hang2, cot2);

	}
	fclose(fp);
	printf("\nGhi xong file mang.txt");

	GiaiPhongBoNho(a, hang1);
	GiaiPhongBoNho(b, hang2);
	if (tong)
		GiaiPhongBoNho(matrantong, hang1);
	if (tich)
		GiaiPhongBoNho(matrantich, hang1);
}

