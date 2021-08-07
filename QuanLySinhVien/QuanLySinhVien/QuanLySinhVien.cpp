#define _CRT_SECURE_NO_DEPRECATE

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
using namespace std;
struct SinhVien {
	char ten[30];
	char gt[5];
	int age;
	float dT, dL, dH;
	float dtb = 0;
};

typedef SinhVien SV;

void nhap(SV& sv);
void LayDsSvHocBong(SV a[], int n);
void TimSV(SV a[], int n);
void nhapN(SV a[], int n);
void xuat(SV sv);
void xuatN(SV a[], int n);
void tinhDTB(SV& sv);
void sapxep(SV a[], int n);
void xeploai(SV a);
void xeploaiN(SV a[], int n);
void xuatFile(SV a[], int n, char fileName[]);

int main() {
	int key;
	char fileName[] = "DSSV.txt";
	int n = 0;
	bool daNhap = false;

	SV a[100];
	while (true) {
		system("cls");
		printf("******************************************\n");
		printf("**    CHUONG TRINH QUAN LY SINH VIEN    **\n");
		printf("**      1. Nhap du lieu                 **\n");
		printf("**      2. Sap xep ds sinh vien         **\n");
		printf("**      3. In Ds sinh vien nhan hoc bong**\n");
		printf("**      4. Tim sinh vien                **\n");
		printf("**      5. Hien thi,Xuat DS sinh vien   **\n");
		printf("**      0. Thoat                        **\n");
		printf("******************************************\n");
		printf("**       Nhap lua chon cua ban          **\n");
		scanf("%d", &key);
		switch (key) {
		case 1:
			do {
				printf("\nNhap so luong SV: ");
				scanf("%d", &n);
			} while (n <= 0);
			printf("\nBan da chon nhap DS sinh vien!");
			nhapN(a, n);
			printf("\nBan da nhap thanh cong!");
			daNhap = true;
			printf("\nBam phim bat ky de tiep tuc!");
			_getch();
			break;
		case 2:
			if (daNhap) {
				printf("\nBan da chon sap xep SV theo ten!");
				sapxep(a, n);
				xuatN(a, n);
			}
			else {
				printf("\nNhap DS SV truoc!!!!");
			}
			printf("\nBam phim bat ky de tiep tuc!");
			_getch();
			break;
		case 3:

			if (daNhap) {
				printf("\nBan da lay sv nhan hoc bong!");
				LayDsSvHocBong(a, n);
			}
			else {
				printf("\nNhap DS SV truoc!!!!");
			}
			_getch();
			printf("\nBam phim bat ky de tiep tuc!");
			break;
		case 4:
			if (daNhap) {
				printf("\nTim SV!");
				TimSV(a, n);
			}
			else {
				printf("\nNhap DS SV truoc!!!!");
			}
			printf("\nBam phim bat ky de tiep tuc!");
			_getch();
			break;
		case 5:
			if (daNhap) {
				printf("\nBan da chon xuat DS SV!");
				xuatN(a, n);
				xuatFile(a, n, fileName);
			}
			else {
				printf("\nNhap DS SV truoc!!!!");
			}
			printf("\nXuat DSSV thanh cong vao file %s!", fileName);
			printf("\nBam phim bat ky de tiep tuc!");
			_getch();
			break;
		case 0:
			printf("\nBan da chon thoat chuong trinh!");
			_getch();
			return 0;
		default:
			printf("\nKhong co chuc nang nay!");
			printf("\nBam phim bat ky de tiep tuc!");
			break;
		}
	}
}

void tinhDTB(SV& sv) {
	sv.dtb = (sv.dH + sv.dL + sv.dT) / 3;
}

void nhap(SV& sv) {
	printf("\nNhap ten: ");
	scanf("%s", sv.ten);
	printf("\nNhap gioi tinh: ");
	scanf("%s", sv.gt);
	printf("\nNhap tuoi: ");
	scanf("%d", &sv.age);
	printf("\nNhap diem 3 mon: ");
	scanf("%f%f%f", &sv.dT, &sv.dL, &sv.dH);
	tinhDTB(sv);
}

void nhapN(SV a[], int n) {
	printf("\n____________________________________\n");
	for (int i = 0; i < n; ++i) {
		printf("\nNhap SV thu %d:", i + 1);
		nhap(a[i]);
	}
	printf("\n____________________________________\n");
}

void xuat(SV sv) {
	printf("\nHo ten SV: %s", sv.ten);
	printf("\nGioi tinh: %s", sv.gt);
	printf("\nTuoi SV  : %d", sv.age);
	printf("\nDiem Toan - Ly - Hoa: %.2f - %.2f - %.2f", sv.dT, sv.dL, sv.dH);
	printf("\nDiem TB: %.2f", sv.dtb);
}

void xuatN(SV a[], int n) {
	printf("\n____________________________________\n");
	for (int i = 0; i < n; ++i) {
		printf("\nThong tin SV thu %d:", i + 1);
		xuat(a[i]);
	}
	printf("\n____________________________________\n");
}

void sapxep(SV a[], int n) {
	//Sap xep theo DTB tang dan
	SV tmp;
	for (int i = 0; i < n; ++i) {
		for (int j = i + 1; j < n; ++j) {
			if (a[i].ten[0] > a[j].ten[0]) {
				tmp = a[i];
				a[i] = a[j];
				a[j] = tmp;
			}
		}
	}
}
void LayDsSvHocBong(SV a[], int n) {
	SV b[100];
	for (int i = 0; i < n; i++)
	{

		b[i] = a[i];
	}
	SV tmp;
	for (int i = 0; i < n; ++i) {
		for (int j = i + 1; j < n; ++j) {
			if (b[j].dtb > b[i].dtb) {
				tmp = b[i];
				b[i] = b[j];
				b[j] = tmp;
			}
		}
	}
	int index = (int)n * 15 / 100;
	if (index == 0)
		index = 1;
	SV c[100];
	int j = 0;
	while (j < index)
	{
		if (b[j].dtb > 7)
			c[j] = b[j];
		j++;
	}
	xuatN(c, index);
}
bool soSanhTen(char a[], char b[]) {
	int na = sizeof(a) / sizeof(a[0]);
	int nb = sizeof(b) / sizeof(b[0]);
	int index = 0;
	if (na < nb)
		index = na;
	else
	{
		index = nb;
	}
	for (int i = 0; i < index; i++)
	{
		if (a[i] != b[i])
			return false;
	}
	return true;
}
void TimSV(SV a[], int n)
{
	char ten[30];
	printf("\nNhap ten sv can tim: ");
	scanf("%s", ten);
	for (int i = 0; i < n; i++)
	{
		if (soSanhTen(a[i].ten, ten)) {
			printf("tim thay sv co ten");
			xuat(a[i]);
			return;
		}
	}
	printf("k tim thay sv them sv moi");
	SV v;
	nhap(v);
	a[n] = v;
	xuatN(a, n + 1);
}
void xeploai(SV sv) {
	if (sv.dtb >= 8) printf("Gioi");
	else if (sv.dtb >= 6.5) printf("Kha");
	else if (sv.dtb >= 4) printf("Trung binh");
	else printf("Yeu");
}

void xeploaiN(SV a[], int n) {
	printf("\n____________________________________\n");
	for (int i = 0; i < n; ++i) {
		printf("\nXep loai cua SV thu %d la: ", i + 1);
		xeploai(a[i]);
	}
	printf("\n____________________________________\n");
}

void xuatFile(SV a[], int n, char fileName[]) {
	FILE* fp;
	fp = fopen(fileName, "w");
	fprintf(fp, "%20s%5s%5s%10s%10s%10s%10s\n", "Ho Ten", "GT", "Tuoi", "DT", "DL", "DH", "DTB");
	for (int i = 0; i < n; i++) {
		fprintf(fp, "%20s%5s%5d%10f%10f%10f%10f\n", a[i].ten, a[i].gt, a[i].age, a[i].dT, a[i].dL, a[i].dH, a[i].dtb);
	}
	fclose(fp);
}
