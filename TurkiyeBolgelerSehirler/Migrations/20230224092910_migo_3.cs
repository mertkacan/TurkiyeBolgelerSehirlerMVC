using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurkiyeBolgelerSehirler.Migrations
{
    public partial class migo_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SehirAd",
                table: "Sehirler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 1,
                column: "Slug",
                value: "akdeniz-bolgesi");

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "Slug",
                value: "dogu-anadolu-bolgesi");

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 3,
                column: "Slug",
                value: "ege-bolgesi");

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 4,
                column: "Slug",
                value: "guneydogu-anadolu-bolgesi");

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 5,
                column: "Slug",
                value: "ic-anadolu-bolgesi");

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 6,
                column: "Slug",
                value: "karadeniz-bolgesi");

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 7,
                column: "Slug",
                value: "marmara-bolgesi");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 1,
                column: "Slug",
                value: "adana");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 2,
                column: "Slug",
                value: "adiyaman");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 3,
                column: "Slug",
                value: "afyonkarahisar");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 4,
                column: "Slug",
                value: "agri");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 5,
                column: "Slug",
                value: "amasya");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 6,
                column: "Slug",
                value: "ankara");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 7,
                column: "Slug",
                value: "antalya");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 8,
                column: "Slug",
                value: "artvin");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 9,
                column: "Slug",
                value: "aydin");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 10,
                column: "Slug",
                value: "balikesir");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 11,
                column: "Slug",
                value: "bilecik");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 12,
                column: "Slug",
                value: "bingol");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 13,
                column: "Slug",
                value: "bitlis");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 14,
                column: "Slug",
                value: "bolu");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 15,
                column: "Slug",
                value: "burdur");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 16,
                column: "Slug",
                value: "bursa");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 17,
                column: "Slug",
                value: "canakkale");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 18,
                column: "Slug",
                value: "cankiri");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 19,
                column: "Slug",
                value: "corum");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 20,
                column: "Slug",
                value: "denizli");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 21,
                column: "Slug",
                value: "diyarbakir");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 22,
                column: "Slug",
                value: "edirne");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 23,
                column: "Slug",
                value: "elazig");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 24,
                column: "Slug",
                value: "erzincan");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 25,
                column: "Slug",
                value: "erzurum");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 26,
                column: "Slug",
                value: "eskisehir");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 27,
                column: "Slug",
                value: "gaziantep");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 28,
                column: "Slug",
                value: "giresun");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 29,
                column: "Slug",
                value: "gumushane");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 30,
                column: "Slug",
                value: "hakkari");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 31,
                column: "Slug",
                value: "hatay");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 32,
                column: "Slug",
                value: "isparta");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 33,
                column: "Slug",
                value: "mersin");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 34,
                column: "Slug",
                value: "istanbul");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 35,
                column: "Slug",
                value: "izmir");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 36,
                column: "Slug",
                value: "kars");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 37,
                column: "Slug",
                value: "kastamonu");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 38,
                column: "Slug",
                value: "kayseri");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 39,
                column: "Slug",
                value: "kirklareli");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 40,
                column: "Slug",
                value: "kirsehir");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 41,
                column: "Slug",
                value: "kocaeli");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 42,
                column: "Slug",
                value: "konya");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 43,
                column: "Slug",
                value: "kutahya");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 44,
                column: "Slug",
                value: "malatya");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 45,
                column: "Slug",
                value: "manisa");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 46,
                column: "Slug",
                value: "kahramanmaras");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 47,
                column: "Slug",
                value: "mardin");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 48,
                column: "Slug",
                value: "mugla");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 49,
                column: "Slug",
                value: "mus");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 50,
                column: "Slug",
                value: "nevsehir");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 51,
                column: "Slug",
                value: "nigde");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 52,
                column: "Slug",
                value: "ordu");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 53,
                column: "Slug",
                value: "rize");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 54,
                column: "Slug",
                value: "sakarya");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 55,
                column: "Slug",
                value: "samsun");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 56,
                column: "Slug",
                value: "siirt");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 57,
                column: "Slug",
                value: "sinop");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 58,
                column: "Slug",
                value: "sivas");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 59,
                column: "Slug",
                value: "tekirdag");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 60,
                column: "Slug",
                value: "tokat");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 61,
                column: "Slug",
                value: "trabzon");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 62,
                column: "Slug",
                value: "tunceli");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 63,
                column: "Slug",
                value: "sanliurfa");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 64,
                column: "Slug",
                value: "usak");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 65,
                column: "Slug",
                value: "van");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 66,
                column: "Slug",
                value: "yozgat");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 67,
                column: "Slug",
                value: "zonguldak");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 68,
                column: "Slug",
                value: "aksaray");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 69,
                column: "Slug",
                value: "bayburt");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 70,
                column: "Slug",
                value: "karaman");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 71,
                column: "Slug",
                value: "kirikkale");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 72,
                column: "Slug",
                value: "batman");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 73,
                column: "Slug",
                value: "sirnak");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 74,
                column: "Slug",
                value: "bartin");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 75,
                column: "Slug",
                value: "ardahan");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 76,
                column: "Slug",
                value: "igdir");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 77,
                column: "Slug",
                value: "yalova");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 78,
                column: "Slug",
                value: "karabuk");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 79,
                column: "Slug",
                value: "kilis");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 80,
                column: "Slug",
                value: "osmaniye");

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 81,
                column: "Slug",
                value: "duzce");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SehirAd",
                table: "Sehirler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 1,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 3,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 4,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 5,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 6,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bolgeler",
                keyColumn: "Id",
                keyValue: 7,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 1,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 2,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 3,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 4,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 5,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 6,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 7,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 8,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 9,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 10,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 11,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 12,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 13,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 14,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 15,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 16,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 17,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 18,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 19,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 20,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 21,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 22,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 23,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 24,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 25,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 26,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 27,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 28,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 29,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 30,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 31,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 32,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 33,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 34,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 35,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 36,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 37,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 38,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 39,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 40,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 41,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 42,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 43,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 44,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 45,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 46,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 47,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 48,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 49,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 50,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 51,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 52,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 53,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 54,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 55,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 56,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 57,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 58,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 59,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 60,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 61,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 62,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 63,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 64,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 65,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 66,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 67,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 68,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 69,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 70,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 71,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 72,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 73,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 74,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 75,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 76,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 77,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 78,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 79,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 80,
                column: "Slug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sehirler",
                keyColumn: "Id",
                keyValue: 81,
                column: "Slug",
                value: null);
        }
    }
}
