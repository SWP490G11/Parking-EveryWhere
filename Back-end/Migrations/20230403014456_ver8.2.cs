using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver82 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("036b0775-1db2-415f-9e30-445412b4c591"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("235027f0-f01a-4210-b205-fa31477ef4f7"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("422e906b-643d-4a34-a874-bb865630fddf"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("adecaaea-6ad6-4651-be18-d484c90cfc39"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("b6425a89-41ed-4858-b379-735036e124c6"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("b6de294f-aaad-448d-8e2b-d5101a6de274"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("3f201d83-1d0b-467c-83a8-e8e8a8da5615"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("baf40be6-7951-4ecd-a8aa-132966fe192d"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("c457e907-f32b-448a-ae3d-cf64907011c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("066027ee-0a9c-4dc1-96b1-afef8091bbd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("07452669-eb39-48c9-8a9a-456bb682c06e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("09877103-2ff6-45f2-a9e3-e3c8676e6bd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("12c9f1ba-2065-49d0-b58b-18fe6e08bdfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("151a6730-13e3-4fe8-9dac-05a768856cef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17353aa3-1d26-4eca-83df-9f0948f38e40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("18151f18-e8d2-478d-8f51-a90463e4c3c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("182bff30-d291-423c-9215-618f3d8f4ef2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1e92001c-6cf6-4c39-847e-963bccafedb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("20e3f00d-32ed-43ec-998a-6f0e731193a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("23305bc8-b14c-441b-bb13-4e71ff48c13a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("24b1430a-9cb7-4ec2-bdfc-cef49458698c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2810958b-4099-4554-abce-68c9345ee5f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2a1c598b-c355-4392-bfb2-9e70e17fabb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2ca8d718-c565-4c4f-b8b7-499338202524"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f15f436-3a0c-42e5-8576-9b102964f6a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f19834a-acef-4f1d-b8b8-d87dd1903d53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f55f4c2-5f18-45f9-b4bc-aed87b3f53ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f5b4ace-9f00-4cdc-99f9-4552c5ce955f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("317e6101-778a-45b2-a41a-ac5202723ea7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("33ef5de8-cb69-4227-bbf5-ff37ebd94577"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("367c6682-07b6-459d-8443-83ed23968116"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3a7a51df-d813-4c47-9e70-891b0d573c3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3d1ab949-8a99-4a9d-aba3-fe5464c0350a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4a4d7cfd-20de-4471-87ca-54acc928ee8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4b3e75e5-e070-4582-83da-00df741b9572"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4b5abe39-1e61-4d12-8630-f51af0e10688"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4cdd7559-9e2e-4653-b01c-94512452b038"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5273810c-5e2f-46a9-b8b8-5b8ce4901a31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("544b7905-3bea-4096-b0c6-24a0380a3562"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5459b155-a04c-4396-93ae-28a8e8986829"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("55143f61-738f-4472-8cea-1298b31e3eb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("55cccdc4-afee-4be8-ba4b-7b92494eb6e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("56170298-ab1a-4df7-8752-94cc7631a482"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("575232b4-ebf7-4738-93c3-81f61d87e642"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("587cc5f4-5e81-4ad5-9b29-5eee1b840231"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5976f734-9d71-457c-ace7-13a621e71b72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5a55cbc0-b5fd-4f94-838a-a9d4d28337f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5b37529b-7d4e-403a-8dd0-1567e17f9d98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5b4dbe05-a450-4606-9412-7b7a4a8c2feb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ba13129-b847-4a65-a740-a9f36025b1bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ba4ad85-3344-4c9a-968a-82d384fc91df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5e4bc7eb-13e6-4f19-aa50-0ec23234c27f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5e5ec6c7-6d6d-4c5f-a295-57f33f1f8974"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5efd48ea-1ca1-450a-a923-ae9e869318c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("643af74b-468e-4a38-900c-4332aa23315d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("66b84bf2-eada-4fad-9542-6bf49fde75c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("678b0d0c-fd82-43bd-96ae-eb574541e78d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("71bac348-5faa-446b-a269-7befe3ef24ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("725c5b89-e278-4ce1-a1d1-064c3e6ae5cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("726541e6-cc1f-4b28-b019-48294a14cdb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7ad57d1b-e77f-4d05-9757-b8b0ac0b4d6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7c9b181d-63fd-4a19-8659-a3e45ec700e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7dee1cb1-16c5-4911-ba17-2c2651343d26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7f992492-4177-4f8b-a10f-9beab1a43408"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8998c954-c712-4598-bb79-0c638b2e71c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8af35b0e-7430-4dab-93b7-a5cf68a836d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8ce07fce-d8a9-4519-9dc6-b6e1ca6fc743"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8d1c0218-2135-463f-ab2d-4b8ada05b3fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9007b506-c63c-4185-a97b-6f8365d70d56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("92b3bfeb-9453-41ec-bfc0-80389ac7d96d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("938ed42d-ecab-432e-9cce-f4481c852136"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9818e7c7-bbcd-4e97-a81c-8728fbf5a2f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9eb85694-0a33-455b-9f7d-5bfaea3264e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f6f38a5-a023-4e0b-a393-a7d080bae76b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a0c676ff-f47d-4db3-946c-b093ffab51b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a32dbc0b-282c-46aa-a5c8-40f6c90cca59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a83247f4-2c72-4943-a23b-8dd7a19fb96a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ae1b702b-cd09-4b20-853f-040fa6a55d63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ae9e6364-b0bd-4725-83a3-11f1b933525a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aee9366a-8e47-467d-81b5-2c37eba21f9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b0b4dc57-dc52-4ab1-a13f-1ec55020c4a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b2657840-26a9-44dc-adf4-eab10a198ae2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b2deaf69-7c23-4415-ae6d-9390250d2012"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b34b0862-2391-4ed5-bc2c-98bfbf465c6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b49d1b0e-93cd-4539-a3fc-49eb8bbc6844"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b618e251-a8fc-4d86-a3f0-c2c04a9bcae2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b8720570-58a7-487e-a69c-dcb1606e0ef9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b99343a6-c37b-4b5c-8f89-c627ade99cf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bc6fba10-f393-4c51-955b-8af37098af44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bcf32d5c-e217-4c9d-9d3b-e27a2c7e2b82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bf61e520-7c27-45e9-adf9-4ee11bac0290"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c2e40f7e-5c97-4d96-b7e2-0595364757f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c3c501d6-f73d-453b-9bc5-1f587b733d65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c42b925b-9619-4fc3-8029-ff673bb05bc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c45ba6bf-e7d7-4497-8d07-55f21a38edf8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c4d8464d-db65-4880-bdbd-4d810efac509"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c8c5e629-f8e5-4324-9fac-546375f67314"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c8cfd9b2-9901-43ec-b04b-7ae8bed88ac2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cb103b6b-75c0-4f25-ae41-d4e3cc582fd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cd9abcc4-84f9-4624-95dc-1760b5fc51e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cdced3f2-72fb-4053-9142-4830d46c1433"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cee75063-928a-4d43-997b-5b304b98b307"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d6665762-c2b4-4195-a9b7-6fc17e686b52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d6a9bf93-e762-457f-989f-cc5154f0d2e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d99c2954-e294-4c83-aaae-a7143c982156"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dad93d2d-8798-4cf1-908d-9cd1934277ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dbf0deaa-b002-4180-9129-bc0008e8bbfe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dc62e0b5-5f7a-4ce0-ad06-d1dcf3c982dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e022a049-4ada-4c8b-a52d-c96873c768de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e59aab6d-a277-44ec-aa8c-48f40c0adbf8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ecde6a14-af14-4adc-8b1b-7d5c8aafb113"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f07b9f22-9c3b-46bd-9501-fe6cad24012a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f132bb1d-a37d-4e7d-b937-e73c4b10c3b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f1edf458-88c0-4f56-aed4-4217ac0531a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f20a5c2b-65c0-41c3-bf6a-2029fcf34ffa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f2fba7b5-e424-4fe0-9f42-5c394b7d1fa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f486b9ff-a4ff-4dfb-9b52-1cf77ac9a6cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f4fa0f96-37a5-49b0-9143-2a223751c802"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f5f0a321-362e-4c18-9e39-1ed3065d3b80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f6c0b28c-69a0-4f3b-b181-d9abbfde4150"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fa78dde4-446b-4410-a2f5-6fadc0e3698e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fbc87d2f-b489-409d-80b7-5694572242a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fcea9a15-c1e2-4efa-93bb-002d27016dec"));

            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "PublicID",
                table: "Images");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("0099045a-a32f-4e7e-8a31-01602f145460"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("57af7173-8268-467e-bb67-c0d64fe9b21c"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("ac2d4a7d-2372-42bc-badb-e84dd6652cfa"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("b0ebbd50-deab-45cd-84c7-1bff5501e95a"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("b5500fb3-1927-405a-b8d4-36ae7e55d914"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("f751c094-ff1b-4c2d-9ef4-68389d544f21"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("2fcc6c82-6c00-43eb-855c-766bb6bf3f1d"), "Half Year", new DateTime(2023, 4, 3, 8, 44, 56, 238, DateTimeKind.Local).AddTicks(9018), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b257a55-6a35-48b1-ae78-71343b8176b4"), "1 Year", new DateTime(2023, 4, 3, 8, 44, 56, 238, DateTimeKind.Local).AddTicks(9020), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc1393ac-0e9f-48ba-b3c0-12ca169ea14c"), "Short time", new DateTime(2023, 4, 3, 8, 44, 56, 238, DateTimeKind.Local).AddTicks(9012), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("01539818-dd4f-4a62-ba7c-24aba9c30262"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$2QJ4IFxqqVGUW1W/rvc2Sef56O5g.VUsJl8DBVwHxbounvsjG0xMy", false, new DateTime(2023, 4, 3, 8, 44, 46, 759, DateTimeKind.Local).AddTicks(8702), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("0243bf79-4776-4adc-8b5b-56d5e78af683"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$lIKjJdT7p3FueMR.U2eWAOIaNN8MvVN3zDlKENVoopI6g1I3a7Xli", false, new DateTime(2023, 4, 3, 8, 44, 53, 676, DateTimeKind.Local).AddTicks(6244), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("034158b4-3c9c-45af-82b3-b7aa57e84d6c"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$zt73ezku/O2OjXPLm6ueGuomqcyjSUX4tth6r7ijbt40td1IeU5cO", false, new DateTime(2023, 4, 3, 8, 44, 45, 631, DateTimeKind.Local).AddTicks(4235), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("035449e1-5990-49e1-8485-47ac839d7728"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$zdMdObspPI3pWmy3psEZSuTLgszTw92cdK2KJrLdGXgYcOhE0mkx.", false, new DateTime(2023, 4, 3, 8, 44, 44, 2, DateTimeKind.Local).AddTicks(3694), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("03f1f1dc-615b-451e-a267-31f2b0f8d5aa"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$0wm2ym5U14BJVv360HMfvu3j5pP0nKvu4MssoP27X1LZIhMBKC19.", false, new DateTime(2023, 4, 3, 8, 44, 48, 608, DateTimeKind.Local).AddTicks(3068), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("04a89a22-4d7d-48bd-8f69-14541cfdd644"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$WaQFpHpyHVHBI2aXcs9M7eRDHhP3weEf.eOUzuSn.NYTrdq.GCB0y", false, new DateTime(2023, 4, 3, 8, 44, 53, 157, DateTimeKind.Local).AddTicks(6058), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("05e1b528-6a56-42bd-ad2a-ed4754165863"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$E8zm8WVBPi9EvEGn9a6HGuLaPsre4Z7L3itT0.S.9tYc/rVW/cnmW", false, new DateTime(2023, 4, 3, 8, 44, 50, 46, DateTimeKind.Local).AddTicks(2505), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("0762ca48-84e4-4ab7-ac89-2a632eda8069"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$hTyLNvGkY.O.queblXS7ieA6HrfklC1vCpoi9urG3JkJXpQ.IJs6y", false, new DateTime(2023, 4, 3, 8, 44, 45, 43, DateTimeKind.Local).AddTicks(4462), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("083daa44-a053-468c-839c-a64b46fdfe9d"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$0aQd5e2qZVmktU5W9er6eOM4wOqRe4ru.TxqMeeFQ.u4qOW0Qfp/u", false, new DateTime(2023, 4, 3, 8, 44, 44, 785, DateTimeKind.Local).AddTicks(5630), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("0992bd70-7669-40f8-90d6-e6c5fb3504fe"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$F/Yi.GIrb.0oVa9fE41U9OK59YjUozMYYtqVeEYfJUMmg5FiAguSy", false, new DateTime(2023, 4, 3, 8, 44, 43, 304, DateTimeKind.Local).AddTicks(6423), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("0afde098-0a56-4130-a40b-36372ded8215"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$vPIFcLFZbFDqlcY4rqy6aesxFQzNb4390HpwBSrDu0Zg2mdghPPzi", false, new DateTime(2023, 4, 3, 8, 44, 49, 46, DateTimeKind.Local).AddTicks(7412), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("0bbb64d5-1848-4f70-b37b-039e6ee16600"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$nAwT0sJKO3hilk1wpLLo7eLAGP64LijLF7Cht18iyhYSetcHWQb0.", false, new DateTime(2023, 4, 3, 8, 44, 43, 590, DateTimeKind.Local).AddTicks(6387), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("12c5cdf3-edea-4782-87e3-f5eb9bdff6d8"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$lsCWPOvSKSodUtmXNPlpoehtaTGq5WQIhT6X90lFSXU2gw1USjqUq", false, new DateTime(2023, 4, 3, 8, 44, 50, 340, DateTimeKind.Local).AddTicks(7044), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("17651456-6edc-4204-b635-31e159d03546"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$f41uolWTV//gD6ZqBpcHkON.AibfSJDacUCJCkIqh7.COjjutVuh6", false, new DateTime(2023, 4, 3, 8, 44, 54, 597, DateTimeKind.Local).AddTicks(5819), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("17a3c8e1-8c6a-49d7-a550-b7a339d26089"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$ohoH3FmmVEfDGpNSiDzYpOo.RJud67oTYCIpCHbhmPOY3ygmotARy", false, new DateTime(2023, 4, 3, 8, 44, 48, 706, DateTimeKind.Local).AddTicks(6974), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("19c72691-6c5c-4b03-9633-99d56bfd0321"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$sbv0lor17YX/mmAPud8QXuBkDAC4k3DDeYfmWZVjyK1N34CalVZWC", false, new DateTime(2023, 4, 3, 8, 44, 48, 819, DateTimeKind.Local).AddTicks(8528), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("1a0484ab-f3e1-44d0-b3a6-df120f698c9d"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$bFyFioUvxuBl2fLC15iIwexvrTymF.dw9PI2YqqN3uvKWWLU5ihQi", false, new DateTime(2023, 4, 3, 8, 44, 46, 339, DateTimeKind.Local).AddTicks(2200), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("1aadfdea-18f4-4222-819d-ee99b83446fe"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$TY.99K.iU6..Z2o.B3WPkODYHuLG8zZtYXbtOjYlPjBT2/Ruyrw1u", false, new DateTime(2023, 4, 3, 8, 44, 47, 656, DateTimeKind.Local).AddTicks(928), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("20440839-e2e8-473b-947f-70347c65fe0c"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$JkuM9Zg5SUxH330zkF3kz.UHcbn7X1EMPLJpVJnirXlOUMa4HkrrK", false, new DateTime(2023, 4, 3, 8, 44, 54, 807, DateTimeKind.Local).AddTicks(6553), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("21c72b12-2436-48b3-af18-795d42ea2947"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$ShLxBN4a/ncqWBcNOE2y5eiNB2SdNpalzPEU8cRFTY1uEXgefbeAe", false, new DateTime(2023, 4, 3, 8, 44, 53, 25, DateTimeKind.Local).AddTicks(1879), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("2200d21d-a795-479a-8fae-0222cf2e579b"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$JgzzCjQFHY2wF1YImnVx4.gzGWCLjDWPgiroDx2gkysaPFhDs6iDa", false, new DateTime(2023, 4, 3, 8, 44, 48, 922, DateTimeKind.Local).AddTicks(8312), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("2570ff72-01a9-49a0-9ac2-4af522b9976f"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$W2VRHOva.ZvPwduo7hEGnOABhns/Fw6RfhohnCfJQ4r.7rbkQCMZC", false, new DateTime(2023, 4, 3, 8, 44, 54, 146, DateTimeKind.Local).AddTicks(9992), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("276d3658-af87-4918-8974-f556bffc0590"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$muYFAD4c6OdTrgn6ikWFmOk60KUSPeKM4ZsK/vf7uZzGf9bZ.TLYq", false, new DateTime(2023, 4, 3, 8, 44, 50, 194, DateTimeKind.Local).AddTicks(5179), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("28dfeab2-b98c-4469-b058-686adb4feb64"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$0Uga8tRwTYLId/TBw5/JFOUX35ASVvF31BQ1hW/VqQPFMt3wItYFS", false, new DateTime(2023, 4, 3, 8, 44, 43, 880, DateTimeKind.Local).AddTicks(7173), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("2d39c9c3-f6a7-4aa0-ada3-38857e632a55"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$9Tt/ZSY7agv9paT69lHhAuBkrviViVeaYzCYYklZdPqE3CJWtWTve", false, new DateTime(2023, 4, 3, 8, 44, 52, 781, DateTimeKind.Local).AddTicks(5001), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("2fb76a09-ae6b-424b-9afc-a9a471e8f043"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$XQ73ypQx7cdr5Jriy5FIz.hZn34LmL0aJz.sfTTxhOIuM/VZ9LkzG", false, new DateTime(2023, 4, 3, 8, 44, 55, 456, DateTimeKind.Local).AddTicks(2374), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("3178f9ca-80cb-45a2-af60-bcaddac79960"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$HTr.0n9fzZJKrRVuaalcLuuDAlBvh/7PnKxkFPEgkKQ2gunQ47HMK", false, new DateTime(2023, 4, 3, 8, 44, 49, 156, DateTimeKind.Local).AddTicks(545), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("31a192f6-b07d-4296-9cde-120b626031b4"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$cdMJAWBGEKNQ8vGXoApzUutEPbQ8JlVG94NBHFFvSeaACXC.6nASe", false, new DateTime(2023, 4, 3, 8, 44, 45, 158, DateTimeKind.Local).AddTicks(3178), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("31b77618-cb01-4e9f-a755-edc84954e71a"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$rvuDLLllQk.MEBF/OR.KOOXt5D/Y6Rb1v7XKNlPMfcRC1rAM2doOS", false, new DateTime(2023, 4, 3, 8, 44, 45, 783, DateTimeKind.Local).AddTicks(9720), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("331d9deb-ba18-48e0-8792-30e221d3767d"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$FqV7DR7iNL/O.gnQNLQpkeVh8bXLk12tXcyULmx.CcU8mP5FQm.HK", false, new DateTime(2023, 4, 3, 8, 44, 48, 244, DateTimeKind.Local).AddTicks(833), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("34631a6a-1ba8-43ef-851f-fb90f3219df7"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$ksrbrOunk93KL5HU1u2/cOjY9Lsclh0BzTHOnNgiTF.oqGAiU1DjW", false, new DateTime(2023, 4, 3, 8, 44, 54, 481, DateTimeKind.Local).AddTicks(8273), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("34b82da9-6660-490d-be64-5eb06e46e935"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$Che47B11gfVQ/zzcZyS43.aMXFF5upPGx0V1sB53FxERETW3UZnOS", false, new DateTime(2023, 4, 3, 8, 44, 54, 16, DateTimeKind.Local).AddTicks(4326), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("35c62e00-a694-45b0-a264-9d61d46c947e"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$iYOP9ASDdeJc.3E8AkEwdeHS0SS8HONWya2ODCBn8On2Yic5mVmz.", false, new DateTime(2023, 4, 3, 8, 44, 46, 648, DateTimeKind.Local).AddTicks(7156), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("36af18bf-1b2a-4593-b2e2-e599543e5fbb"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$xh5wMZkRMHrcDaYBUp1DLeuME2rt4nMo8Hn.EhZt9KPGpx9NDm0h6", false, new DateTime(2023, 4, 3, 8, 44, 42, 997, DateTimeKind.Local).AddTicks(4164), " Nguyen Van", null, null, "0966416708", -772000, "customer" },
                    { new Guid("38d9c589-4e90-49a9-a8f4-3466aa22390d"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$Vfgblx/uEdgGg5Za/HrRm.tnVzQ0SAKMJ9/mA0i1PIGJNcLnlcDWG", false, new DateTime(2023, 4, 3, 8, 44, 49, 907, DateTimeKind.Local).AddTicks(1963), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("39f8b45a-8e27-4b4a-8b7b-21047262475e"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$dfzO6E1wwO4eA.2CjusVp.fCr3lnhInl7OdjPC425lwB1NT0WdNZ.", false, new DateTime(2023, 4, 3, 8, 44, 53, 785, DateTimeKind.Local).AddTicks(1686), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("3c0075f2-a73c-452a-8080-4dac314deca9"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$V69NVrW77bV6QgLR0RB8XeWr8RQTpfql1A9JvvlMWqednvnU1t7vi", false, new DateTime(2023, 4, 3, 8, 44, 42, 880, DateTimeKind.Local).AddTicks(7922), " Ass min", null, null, "0966416708", -772000, "admin" },
                    { new Guid("4177b460-f2fb-4f89-8fb2-88816f4c3269"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$gxtJy2v8BExe0suNCAySNe2fFlXO3FhjE7qN1IOTlcspWQlAUMzh2", false, new DateTime(2023, 4, 3, 8, 44, 49, 291, DateTimeKind.Local).AddTicks(5369), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("487d9dc6-17ad-4207-8b67-df67e51c13e0"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$HkGDoH47/hwxpl2UUp3oJumhK3Imjh94wiD2aMY2dZdQIZnXfxEla", false, new DateTime(2023, 4, 3, 8, 44, 47, 13, DateTimeKind.Local).AddTicks(4809), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("493f4030-9f5a-47fd-a08b-c715bf0efc6a"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$RtHLPkL3M.zBTkV4hWLQ/Oo46N/b8EscGyx5WGN8viUP5PiLr0nRG", false, new DateTime(2023, 4, 3, 8, 44, 52, 180, DateTimeKind.Local).AddTicks(3093), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("4b497080-6a52-49c3-b632-75f467da0383"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$7APfJjEUP5YptqIrjy0Oce4oDzOtdiWKG7bMdejFbGQHUQSXjcvc6", false, new DateTime(2023, 4, 3, 8, 44, 43, 155, DateTimeKind.Local).AddTicks(407), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("4bae5117-4ebf-4b8a-af8d-18b5104e7ec4"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$Qw2HIpq0RcIjWrGtS/N/fOGgnHbikR7rNEIoABMxDPYl1wxFIaKFC", false, new DateTime(2023, 4, 3, 8, 44, 51, 258, DateTimeKind.Local).AddTicks(1008), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("4f2bf3fd-b37c-474e-a829-41ed21d9ce71"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$XyYuck/Ox7W8L4kUjzEpKOEnTeZ3yRP9QX0MFhzdfhCVowr6Qx6N6", false, new DateTime(2023, 4, 3, 8, 44, 52, 645, DateTimeKind.Local).AddTicks(4589), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("4fafe2c3-afae-4fc2-9915-140dca5daefd"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$OdtmvLPi2tYm0rcdlJZnkOpwEP8JnAMWz1oruFPXp89Ue6QJzJY/m", false, new DateTime(2023, 4, 3, 8, 44, 50, 991, DateTimeKind.Local).AddTicks(4507), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("527b799a-7900-49a1-9816-3129e4ad7ead"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$KWPDxI3xULe4/YLDZXL0seVhSrADr3kcJCqiJHj6g1MFls00cPEWG", false, new DateTime(2023, 4, 3, 8, 44, 55, 153, DateTimeKind.Local).AddTicks(5318), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("5325f594-b66f-4410-b56c-8c81bf6571a0"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$lpgifGyxsA64X6MNnllkBeobhWpEUnni4Y1WEMQI9BVpkDAJz8qL.", false, new DateTime(2023, 4, 3, 8, 44, 51, 362, DateTimeKind.Local).AddTicks(4973), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("5a5b3c71-ab1d-4072-8dfb-5ff748d1ab77"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$Q7wO2V/F6pnjwnXxdqYBb.cdZzOUVZSrjooxg2ZSaGVwPUIWrxDoq", false, new DateTime(2023, 4, 3, 8, 44, 48, 2, DateTimeKind.Local).AddTicks(8042), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("5ab26f10-315b-4ade-8623-c58dc1ed0e88"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$SRZNq/KaPmIep9NMsNo4zOPJYjj6RA4sLwA/tSR.hV0zwQZyiOaAa", false, new DateTime(2023, 4, 3, 8, 44, 51, 131, DateTimeKind.Local).AddTicks(9625), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("5b7f230b-0d06-4f8f-872a-397f97629b66"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$IqpkfrmudU0IeN1bjU237ePVglEd/eRfDIc.CKdGQXvBj6o3moXBS", false, new DateTime(2023, 4, 3, 8, 44, 43, 709, DateTimeKind.Local).AddTicks(7886), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("62b8e36a-4b0f-4719-8f3e-8ec0bdf8f3a3"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$vRF0vfEbgm/iljmDbE1Q/eYqL0b2Muj7JB1Yn9mnVO6uPLoyNiLDq", false, new DateTime(2023, 4, 3, 8, 44, 53, 893, DateTimeKind.Local).AddTicks(5338), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("64a78d09-01fc-4aea-8e49-4d8cf057b6e4"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$wbLXO930UJiAejgcLRxbv.ZON361LHPaQ6F1XVEV/WxA4ygbctVse", false, new DateTime(2023, 4, 3, 8, 44, 47, 763, DateTimeKind.Local).AddTicks(6446), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("6770e215-eac8-4e3c-b5e9-1151a1e7e40d"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$f9kQbH5TW4Q8J.7pqhwOs.0wFBsxcYPRSOS87DApoibVcQtdv9.gi", false, new DateTime(2023, 4, 3, 8, 44, 56, 238, DateTimeKind.Local).AddTicks(8319), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("6aa5d534-7f97-416a-9f86-4084c828550a"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$UGWZ3o0utimkoSlZ4yhTPe.O5HOHb95Mmz7MP8uhuIqWXuvhrdhlu", false, new DateTime(2023, 4, 3, 8, 44, 52, 294, DateTimeKind.Local).AddTicks(6063), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("6afbf6ca-e96e-4ee4-a910-90256b81b078"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$3nxhss4wvx/ZRw3nEnb0g.N1FHOeW5uX6Oe0XWYnbZ7CmTV.PiR4S", false, new DateTime(2023, 4, 3, 8, 44, 53, 278, DateTimeKind.Local).AddTicks(9840), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("6e547c60-30dc-45ed-bab2-0eb8fb33a611"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$W9Jj9j3cpbmVmujXR6fhcOveN1QSRdmePYzJ7AgGYh6U.IJB5B/n2", false, new DateTime(2023, 4, 3, 8, 44, 47, 445, DateTimeKind.Local).AddTicks(9845), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("7321bedd-7b5d-4fb0-bea1-1fa54465d44b"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$rm2l2RkvHHH64/3WNFgVLOYYB2NB4uiXGgKN4ReJR8HMftORUNLS2", false, new DateTime(2023, 4, 3, 8, 44, 50, 763, DateTimeKind.Local).AddTicks(7836), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("74a179fa-88fb-4b52-b0d6-e9a1cc53d656"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$5dBFObig7B8L34ReaQHdL.vdRCUIB/vC/4OFjhsvBiJPhnyzEu6o2", false, new DateTime(2023, 4, 3, 8, 44, 48, 141, DateTimeKind.Local).AddTicks(404), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("74e0656d-a357-4018-96d8-7e91037ffbbf"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$HC7NYkJF3T0v/ZY9baLMJOrngfkzGC5NOuYktVxeeHIeqW5l68YZW", false, new DateTime(2023, 4, 3, 8, 44, 54, 914, DateTimeKind.Local).AddTicks(5478), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("75282bcc-7171-4785-9d2c-854fce5779bd"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$XN86nl8gu8XA6cznEfJ5wuH64s/kJEF9Rz3FVOCXj5v42Xfl1g6mC", false, new DateTime(2023, 4, 3, 8, 44, 56, 143, DateTimeKind.Local).AddTicks(9187), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("760adb58-2cea-4c3e-b675-9daa6893515a"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$ukKdug.FtLnwdMz6A0xFkOWdyB5bQytHLfNZh45fpl.GqrlnPuq5a", false, new DateTime(2023, 4, 3, 8, 44, 44, 926, DateTimeKind.Local).AddTicks(2665), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("7666e789-fe6c-4914-84e9-19cc65492e62"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$tO9pRaOFa81ABdJpz8g5c./Mxu3Bowd3G9R.xhGg1w5JWvwBL0bAq", false, new DateTime(2023, 4, 3, 8, 44, 44, 685, DateTimeKind.Local).AddTicks(2981), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("7799dfe3-2ac7-4920-9edf-36d1630cb8f0"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$U3B3TueMsbYvm.Pk5Q3DU.mcGpukdQ2pn7hRb51IjsOPyMdc.0qZC", false, new DateTime(2023, 4, 3, 8, 44, 55, 683, DateTimeKind.Local).AddTicks(9644), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("7a3d7f48-9a4a-4e35-aaa6-eaaf5a1226d5"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$1uVaXYD5byZuWLo9vs1s1e0EMJgZtGfXDZwe00Kylo1hFYhuShzOW", false, new DateTime(2023, 4, 3, 8, 44, 49, 763, DateTimeKind.Local).AddTicks(9422), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("7cd6d20e-ed52-4ace-b972-d1b38ee1dded"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$mGvkzEJ.1EtDVHPppq8y6u0ittAJQm1aFbzJDC6XU/1tG8HPhCHGu", false, new DateTime(2023, 4, 3, 8, 44, 50, 619, DateTimeKind.Local).AddTicks(7254), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("7d1fd6d3-b555-4264-9aef-a0fd7a52c2c2"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$bbRJ5tlwet5x/a29UlYNkeg2VavP4vMVSe2AqYJhLXoXiKrRFajlm", false, new DateTime(2023, 4, 3, 8, 44, 44, 233, DateTimeKind.Local).AddTicks(4757), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("80b6f457-5943-440d-8dc6-c5f03daf4b55"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$MtX51ldRNIOq84tYy20kd.xBVnt610jwu2f4K09kkSSQDoHNK5pSS", false, new DateTime(2023, 4, 3, 8, 44, 53, 394, DateTimeKind.Local).AddTicks(6680), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("812eecde-d9be-48d1-aefe-2d71aeeafdc6"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$0Z9pwUS2LRgJ7lJI8RBhXuLbMrLYJO.1YpRVmLU6gS6I4tm76s/.O", false, new DateTime(2023, 4, 3, 8, 44, 44, 454, DateTimeKind.Local).AddTicks(447), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("83c825b7-6a8f-49a0-ba45-194aa5df0aa9"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$CYsCrn1IZzHQl7jWipCfBuv6ym.48/oRr5bCBnNGhO0wVL90fJwSG", false, new DateTime(2023, 4, 3, 8, 44, 56, 43, DateTimeKind.Local).AddTicks(349), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("841682eb-99b1-4533-809e-ac0cb1b97162"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$njBNn8JF4W4z5gld6rf1nu9AQxtpWJ0ftUsktInRIEVCQz1GFxEtG", false, new DateTime(2023, 4, 3, 8, 44, 47, 552, DateTimeKind.Local).AddTicks(8013), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("84ea59fb-2c6c-49b4-a611-2a410dfb50a9"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$507L9tRGe425929hiCDkQuvu0mUKgLnqhesPRw0gMlVFpgob1oxFW", false, new DateTime(2023, 4, 3, 8, 44, 50, 883, DateTimeKind.Local).AddTicks(6338), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("898028ad-3c2a-4bc0-ae0e-7b75b60c8ebc"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$Wuu19dOjyRygnDRkB4zWnOHFvPSa1sO1m91mhYzpyVl2gH8kpsv2.", false, new DateTime(2023, 4, 3, 8, 44, 44, 117, DateTimeKind.Local).AddTicks(328), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("89f9f845-84c4-4372-a446-d3ae8cea825d"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$5Tzig7bzU8D2iR4Iktm05etaMiRDV0tai8gib6X2L8VnkrQ5ychce", false, new DateTime(2023, 4, 3, 8, 44, 48, 374, DateTimeKind.Local).AddTicks(9836), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("90bc8607-cb1f-4a19-8192-f19da3cd2e67"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$.wRAtE9LR4IAYOk2YZ7PxOKsymylcN47MiV2SAsCQbnh./FvIcG/m", false, new DateTime(2023, 4, 3, 8, 44, 55, 26, DateTimeKind.Local).AddTicks(4044), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("926b1b6f-9b44-4352-a5b5-9940c5ce1f80"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$pdkPPP8fv71d8nj3jSqcRu3jHm1kKrKG5xCRUfuLoiJn.HV6mKflu", false, new DateTime(2023, 4, 3, 8, 44, 45, 994, DateTimeKind.Local).AddTicks(8944), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("944fa584-2321-4c60-9de5-ea0409864f6a"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$lo2UWFKdSSLeOz9MQSYkO.fCCGEgVb8PKWeTPHbKmmaf9Dc5XFJdW", false, new DateTime(2023, 4, 3, 8, 44, 51, 818, DateTimeKind.Local).AddTicks(7315), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("9a80d06a-752d-48db-a688-189030dda07f"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$KkfUcNCvFQJ48EDl9Ld5NO7ekAYxqafp2vZmzKb9mzMRzeZzHlyY.", false, new DateTime(2023, 4, 3, 8, 44, 51, 604, DateTimeKind.Local).AddTicks(882), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("9b53525a-5cb9-42a7-a893-3da571bffe27"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$IBzi3.6bhVdRfQrwTma8R.HqsROyov1fz6N.WmYYYtsudr8zLapYu", false, new DateTime(2023, 4, 3, 8, 44, 45, 275, DateTimeKind.Local).AddTicks(6117), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("9dac4881-db8b-4a2b-af64-5a49ba17b991"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$DIiauu6SeeF4a05zqa/c4eq4Lx9QNgRZrOD5S9EBuRUUEsLBXLfZq", false, new DateTime(2023, 4, 3, 8, 44, 42, 741, DateTimeKind.Local).AddTicks(8249), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("9dc5883b-61aa-48ef-a661-849c41e3ee9b"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$f5njVNlzAouXqhWTqvnbHeZFU2C5JgbdMHyHvkEopEs6nUBeLd0qq", false, new DateTime(2023, 4, 3, 8, 44, 55, 938, DateTimeKind.Local).AddTicks(7212), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("9f43de80-a5e1-413d-9f84-2c6dd3c63ce1"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$HYE1hjfLgKbttbXRXj2Iqec4WC0XdSpCk8.G0n4TTQZIid7xZv1UC", false, new DateTime(2023, 4, 3, 8, 44, 54, 258, DateTimeKind.Local).AddTicks(445), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("a463fcde-54f9-41bf-abe5-3e4fbf72a470"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$jf0J0qwsk3g8DPP2V4tPXeED9XyJn8QgqOAAEkmp3KLWQ9A6yiM7i", false, new DateTime(2023, 4, 3, 8, 44, 54, 364, DateTimeKind.Local).AddTicks(4090), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("a69411f8-d000-49a7-a68f-6a1c91e291bc"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$W2mpdHFhNVnVsJzm0RxTKuktAZYwNfV3VbnTD8cdP9Upwm.PLyHi2", false, new DateTime(2023, 4, 3, 8, 44, 43, 455, DateTimeKind.Local).AddTicks(6745), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("a92bb3a4-3774-4635-97c4-a5be34d40726"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$FEa1NXCJSnQa7dFuWg1SJePGcUvvY7Lq3ROyDtrwumz/ZII.QCli.", false, new DateTime(2023, 4, 3, 8, 44, 50, 493, DateTimeKind.Local).AddTicks(2127), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("b0bb5422-34d6-444c-8b84-dc396f212663"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$m8LeHljpk1mI2vFEy0Gji.VQuYS.zW8FOTR.7L7V4dOq2bYAkoPPa", false, new DateTime(2023, 4, 3, 8, 44, 52, 520, DateTimeKind.Local).AddTicks(3989), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("b1446209-d26e-485d-9036-fffee3642f98"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$C72gP0Ia3Cd5cMjHIwkKoOV83UJBWSVf3gRNPWlBRfMz9lPkQXtnK", false, new DateTime(2023, 4, 3, 8, 44, 48, 500, DateTimeKind.Local).AddTicks(7556), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("b2a70b15-486f-48cb-9fd7-09aaaa3275b0"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$n52T6dPE5ReojUKmdKeZ7OnGGXr8OtrWqWdWr2p7cIn/JJb9k1oiG", false, new DateTime(2023, 4, 3, 8, 44, 46, 90, DateTimeKind.Local).AddTicks(4309), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("b5886d91-afc1-4d17-b71f-c1fdd0a07f2c"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$fzMYaAHWtlW.izc3XKnDCeeNUxOR/sDGO10a6qmv5j34DQX7ztd.2", false, new DateTime(2023, 4, 3, 8, 44, 55, 256, DateTimeKind.Local).AddTicks(4126), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("b75914cd-49ea-477c-a006-1fdeaeaaaa60"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$c0BBtnZJBmyCLVP5yNPMNe7h1xzvSaYZxPuZ873LF6uG14CvudQ/C", false, new DateTime(2023, 4, 3, 8, 44, 47, 890, DateTimeKind.Local).AddTicks(6426), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("b7cdb0a5-b954-4c7c-8d42-2c542d815188"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$GXP/6lRA/Inv.yGhkzLRIuKKbFkXUblH5kaDsox0ZzGkAGCP2BfqW", false, new DateTime(2023, 4, 3, 8, 44, 52, 916, DateTimeKind.Local).AddTicks(7740), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("bcdd6694-fac0-43da-bde6-39194cc9c01a"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$G7OGm5wtCLquaniaKLYy8eXkIWdf.plwE.1C5PGGHMLmMCpglubQa", false, new DateTime(2023, 4, 3, 8, 44, 47, 231, DateTimeKind.Local).AddTicks(6676), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("bd7f1948-b5e9-403f-a7ab-c947dd757253"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$Dxe6vzqy6pPnpkqrUVup1eC5wS3bq4naw9uzHOdp5hr12SYwlnsOm", false, new DateTime(2023, 4, 3, 8, 44, 46, 209, DateTimeKind.Local).AddTicks(5007), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("c0e68864-0891-474e-af3d-ed807499587a"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$YoewGiGBOzrrB5ioT4aYx.SBgyKE4QEICysEG4ZhCZgA.vBWrFr3W", false, new DateTime(2023, 4, 3, 8, 44, 55, 358, DateTimeKind.Local).AddTicks(3932), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("c4666f5d-d83b-4781-b19b-8d98414cfa2d"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$LNcC8cNrl3ojnHC.vTBuF.nlKgIZXObvnnTDCxWpMfpvYaMOzFtfe", false, new DateTime(2023, 4, 3, 8, 44, 46, 553, DateTimeKind.Local).AddTicks(437), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("c53d67e7-eccd-4694-b322-00ee11419c42"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$EaehvDbUsCZsl0oi7wEfeee9OVh8/lScK.qETDwYQH8XyBsNEDTZy", false, new DateTime(2023, 4, 3, 8, 44, 49, 421, DateTimeKind.Local).AddTicks(4684), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("c74764f4-8fee-4cd2-83db-c7d4bb711f94"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$wpDZ2sqCYZFfOwp71wdTHO40DMv1iE3PedXOuTtzjrnChXXy7E1jW", false, new DateTime(2023, 4, 3, 8, 44, 47, 115, DateTimeKind.Local).AddTicks(5614), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("cce916ab-8c74-4ca2-a716-4227ecb3092e"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$JWPS4a47LAWlu3W/HZUn9eVVvLsyePDq1zjKd47LDQ2/p/qhHxVK.", false, new DateTime(2023, 4, 3, 8, 44, 51, 475, DateTimeKind.Local).AddTicks(6851), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("d3231650-cb7e-43f6-9cf7-2b009acc7ab7"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$jaTGnFB6uV9f2zPUhhSLWex2tUYyTx48iawzs4NaTv/3LXoEHFIcy", false, new DateTime(2023, 4, 3, 8, 44, 49, 534, DateTimeKind.Local).AddTicks(8029), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("d45ebf03-9da3-4124-87ad-c73e2bc7612a"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$s5wAwGHlMJJPrkJxVMq7ZeIlIZkxqmtUgcnsen38JI/nFntZkzGc6", false, new DateTime(2023, 4, 3, 8, 44, 47, 340, DateTimeKind.Local).AddTicks(8623), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("da7d433b-e811-4b39-ac11-eaebbefdbb1d"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$Zc7sg2wllqlT8/xoTQCC9Oe7Wk.X.P30iLVh8x/XfLTeLrBZKEWA.", false, new DateTime(2023, 4, 3, 8, 44, 54, 708, DateTimeKind.Local).AddTicks(6029), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("df1fde54-004e-44e8-bf81-de2faaf07e14"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$cXAQHcZ8FUxYc0xU2kvJous8oNhcqrtK9MDjT5Jei7St5mfUkA9o.", false, new DateTime(2023, 4, 3, 8, 44, 55, 559, DateTimeKind.Local).AddTicks(3100), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("e1877b18-df36-4e59-92f9-4efa49e11a76"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$99ob6r7CePwji0N96cB2g.S77Lrtlm3LAAekeysuleGyd/pUln.De", false, new DateTime(2023, 4, 3, 8, 44, 44, 564, DateTimeKind.Local).AddTicks(5469), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("e363018a-e38d-478e-a366-1bfd9bf2c4bf"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$UmWKHqNcO0xM1Xp9JmKOPeGppPJWZcSdgV6za/hXWiXOm.hEMaCjW", false, new DateTime(2023, 4, 3, 8, 44, 46, 442, DateTimeKind.Local).AddTicks(60), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("e4793e61-f5ea-4917-8fd1-c6fa5235bc73"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$m.35ynDgn2vZVqiqn0.h4OE5J4grrHEeitr3RMFnFef0fjXFwEuYO", false, new DateTime(2023, 4, 3, 8, 44, 45, 891, DateTimeKind.Local).AddTicks(1499), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("e62cead2-64ed-49b0-a984-1fc7eb11e2ff"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$Tk326lzwm3nFTq3Udnk5mOSLmoqLHXKZVbuTvm0sJBViS2r3M4MTm", false, new DateTime(2023, 4, 3, 8, 44, 51, 716, DateTimeKind.Local).AddTicks(8856), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("ee13ac84-d40d-4a08-8ef2-7697258ba555"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$8cH.4gJKO0x7.AFiXUzviOzwpdbDswGbKvE6K8aLHMTsXhU2rZi2i", false, new DateTime(2023, 4, 3, 8, 44, 46, 867, DateTimeKind.Local).AddTicks(9661), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("ee240a02-cdff-46ef-a230-2139a4d04c01"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$CdR7iPj6ckAbdpuVUOdh7uNAJrEpsdLcYt9LeGjLQsMt4sPGQyNfK", false, new DateTime(2023, 4, 3, 8, 44, 49, 657, DateTimeKind.Local).AddTicks(2264), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("f04c5c1d-9ea9-41c4-b6fd-0511344a7f5b"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$/pg1qdeUVteVKjEIMAN3K.kduKtRfPkf4Jouv2Jcl.o0zhH00Ee4u", false, new DateTime(2023, 4, 3, 8, 44, 44, 347, DateTimeKind.Local).AddTicks(7836), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("f39c3c4b-ddb4-40b8-9412-0b58a2771f3d"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$uAehPHNysJBIGLf62tqAm.zYXKeWqs5IqmXezA.XJYvCUqeZVBw0K", false, new DateTime(2023, 4, 3, 8, 44, 45, 382, DateTimeKind.Local).AddTicks(3687), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("f3e10a6a-0bb5-4317-895b-4b7789665207"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$XJxE8LOI/Z/lR.c2aC4.uuwEV2IdN/BQMPa/BAJzrs6nIvfWdvTpu", false, new DateTime(2023, 4, 3, 8, 44, 45, 495, DateTimeKind.Local).AddTicks(4188), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("f593be9f-501d-42c1-a6a9-316abbd1b170"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$FvaaIgsh/T.FOnBfdaa1SOLs8Y9txL30yV0BMGc0IBUb0MXPPAzfG", false, new DateTime(2023, 4, 3, 8, 44, 51, 933, DateTimeKind.Local).AddTicks(6724), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("fb7ed84f-5aca-41e9-8d8c-ef5a4bd6c68e"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$ptRwAtSFNGcMu84R4DIe8elFDThv0bz9dRmL8JUdWoX/Qje3BhZdy", false, new DateTime(2023, 4, 3, 8, 44, 52, 71, DateTimeKind.Local).AddTicks(6801), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("fc82c8b4-af0c-49c0-b5dc-542c618f87a5"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$jP4lQOMqvuSI1v1MAALmrev6GT7lgo6tava1R.Qtxnv77H/Z.WJvC", false, new DateTime(2023, 4, 3, 8, 44, 55, 812, DateTimeKind.Local).AddTicks(8996), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("fd43f104-04a0-45e3-85b7-4bcfd1e5e8c8"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$b9I1xJVoRz7SfndPTLVvH.PvC4Lm16SrbcAl5Tf65w6oRaj9f7DP2", false, new DateTime(2023, 4, 3, 8, 44, 53, 532, DateTimeKind.Local).AddTicks(2369), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("ff89ee6c-7dc5-4ba7-ab8d-0c12530e8177"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$j7GcRg7UMrAbe2aYd.gtR./nKKamg34/Erd6fqLd/4/uzNuHoTyxa", false, new DateTime(2023, 4, 3, 8, 44, 52, 404, DateTimeKind.Local).AddTicks(5317), "Lannen", null, null, "04000508789", 1, "dlannen25" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("0099045a-a32f-4e7e-8a31-01602f145460"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("57af7173-8268-467e-bb67-c0d64fe9b21c"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("ac2d4a7d-2372-42bc-badb-e84dd6652cfa"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("b0ebbd50-deab-45cd-84c7-1bff5501e95a"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("b5500fb3-1927-405a-b8d4-36ae7e55d914"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("f751c094-ff1b-4c2d-9ef4-68389d544f21"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("2fcc6c82-6c00-43eb-855c-766bb6bf3f1d"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("3b257a55-6a35-48b1-ae78-71343b8176b4"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("fc1393ac-0e9f-48ba-b3c0-12ca169ea14c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("01539818-dd4f-4a62-ba7c-24aba9c30262"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0243bf79-4776-4adc-8b5b-56d5e78af683"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("034158b4-3c9c-45af-82b3-b7aa57e84d6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("035449e1-5990-49e1-8485-47ac839d7728"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("03f1f1dc-615b-451e-a267-31f2b0f8d5aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("04a89a22-4d7d-48bd-8f69-14541cfdd644"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("05e1b528-6a56-42bd-ad2a-ed4754165863"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0762ca48-84e4-4ab7-ac89-2a632eda8069"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("083daa44-a053-468c-839c-a64b46fdfe9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0992bd70-7669-40f8-90d6-e6c5fb3504fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0afde098-0a56-4130-a40b-36372ded8215"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0bbb64d5-1848-4f70-b37b-039e6ee16600"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("12c5cdf3-edea-4782-87e3-f5eb9bdff6d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17651456-6edc-4204-b635-31e159d03546"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17a3c8e1-8c6a-49d7-a550-b7a339d26089"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("19c72691-6c5c-4b03-9633-99d56bfd0321"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1a0484ab-f3e1-44d0-b3a6-df120f698c9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1aadfdea-18f4-4222-819d-ee99b83446fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("20440839-e2e8-473b-947f-70347c65fe0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("21c72b12-2436-48b3-af18-795d42ea2947"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2200d21d-a795-479a-8fae-0222cf2e579b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2570ff72-01a9-49a0-9ac2-4af522b9976f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("276d3658-af87-4918-8974-f556bffc0590"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("28dfeab2-b98c-4469-b058-686adb4feb64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2d39c9c3-f6a7-4aa0-ada3-38857e632a55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2fb76a09-ae6b-424b-9afc-a9a471e8f043"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3178f9ca-80cb-45a2-af60-bcaddac79960"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("31a192f6-b07d-4296-9cde-120b626031b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("31b77618-cb01-4e9f-a755-edc84954e71a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("331d9deb-ba18-48e0-8792-30e221d3767d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("34631a6a-1ba8-43ef-851f-fb90f3219df7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("34b82da9-6660-490d-be64-5eb06e46e935"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("35c62e00-a694-45b0-a264-9d61d46c947e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("36af18bf-1b2a-4593-b2e2-e599543e5fbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("38d9c589-4e90-49a9-a8f4-3466aa22390d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("39f8b45a-8e27-4b4a-8b7b-21047262475e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3c0075f2-a73c-452a-8080-4dac314deca9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4177b460-f2fb-4f89-8fb2-88816f4c3269"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("487d9dc6-17ad-4207-8b67-df67e51c13e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("493f4030-9f5a-47fd-a08b-c715bf0efc6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4b497080-6a52-49c3-b632-75f467da0383"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4bae5117-4ebf-4b8a-af8d-18b5104e7ec4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4f2bf3fd-b37c-474e-a829-41ed21d9ce71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4fafe2c3-afae-4fc2-9915-140dca5daefd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("527b799a-7900-49a1-9816-3129e4ad7ead"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5325f594-b66f-4410-b56c-8c81bf6571a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5a5b3c71-ab1d-4072-8dfb-5ff748d1ab77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ab26f10-315b-4ade-8623-c58dc1ed0e88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5b7f230b-0d06-4f8f-872a-397f97629b66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("62b8e36a-4b0f-4719-8f3e-8ec0bdf8f3a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("64a78d09-01fc-4aea-8e49-4d8cf057b6e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6770e215-eac8-4e3c-b5e9-1151a1e7e40d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6aa5d534-7f97-416a-9f86-4084c828550a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6afbf6ca-e96e-4ee4-a910-90256b81b078"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6e547c60-30dc-45ed-bab2-0eb8fb33a611"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7321bedd-7b5d-4fb0-bea1-1fa54465d44b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74a179fa-88fb-4b52-b0d6-e9a1cc53d656"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74e0656d-a357-4018-96d8-7e91037ffbbf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("75282bcc-7171-4785-9d2c-854fce5779bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("760adb58-2cea-4c3e-b675-9daa6893515a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7666e789-fe6c-4914-84e9-19cc65492e62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7799dfe3-2ac7-4920-9edf-36d1630cb8f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7a3d7f48-9a4a-4e35-aaa6-eaaf5a1226d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7cd6d20e-ed52-4ace-b972-d1b38ee1dded"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d1fd6d3-b555-4264-9aef-a0fd7a52c2c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("80b6f457-5943-440d-8dc6-c5f03daf4b55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("812eecde-d9be-48d1-aefe-2d71aeeafdc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83c825b7-6a8f-49a0-ba45-194aa5df0aa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("841682eb-99b1-4533-809e-ac0cb1b97162"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("84ea59fb-2c6c-49b4-a611-2a410dfb50a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("898028ad-3c2a-4bc0-ae0e-7b75b60c8ebc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("89f9f845-84c4-4372-a446-d3ae8cea825d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("90bc8607-cb1f-4a19-8192-f19da3cd2e67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("926b1b6f-9b44-4352-a5b5-9940c5ce1f80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("944fa584-2321-4c60-9de5-ea0409864f6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9a80d06a-752d-48db-a688-189030dda07f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9b53525a-5cb9-42a7-a893-3da571bffe27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9dac4881-db8b-4a2b-af64-5a49ba17b991"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9dc5883b-61aa-48ef-a661-849c41e3ee9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f43de80-a5e1-413d-9f84-2c6dd3c63ce1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a463fcde-54f9-41bf-abe5-3e4fbf72a470"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a69411f8-d000-49a7-a68f-6a1c91e291bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a92bb3a4-3774-4635-97c4-a5be34d40726"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b0bb5422-34d6-444c-8b84-dc396f212663"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b1446209-d26e-485d-9036-fffee3642f98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b2a70b15-486f-48cb-9fd7-09aaaa3275b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b5886d91-afc1-4d17-b71f-c1fdd0a07f2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b75914cd-49ea-477c-a006-1fdeaeaaaa60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b7cdb0a5-b954-4c7c-8d42-2c542d815188"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bcdd6694-fac0-43da-bde6-39194cc9c01a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd7f1948-b5e9-403f-a7ab-c947dd757253"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c0e68864-0891-474e-af3d-ed807499587a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c4666f5d-d83b-4781-b19b-8d98414cfa2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c53d67e7-eccd-4694-b322-00ee11419c42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c74764f4-8fee-4cd2-83db-c7d4bb711f94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cce916ab-8c74-4ca2-a716-4227ecb3092e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d3231650-cb7e-43f6-9cf7-2b009acc7ab7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d45ebf03-9da3-4124-87ad-c73e2bc7612a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("da7d433b-e811-4b39-ac11-eaebbefdbb1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("df1fde54-004e-44e8-bf81-de2faaf07e14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e1877b18-df36-4e59-92f9-4efa49e11a76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e363018a-e38d-478e-a366-1bfd9bf2c4bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4793e61-f5ea-4917-8fd1-c6fa5235bc73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e62cead2-64ed-49b0-a984-1fc7eb11e2ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee13ac84-d40d-4a08-8ef2-7697258ba555"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee240a02-cdff-46ef-a230-2139a4d04c01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f04c5c1d-9ea9-41c4-b6fd-0511344a7f5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f39c3c4b-ddb4-40b8-9412-0b58a2771f3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3e10a6a-0bb5-4317-895b-4b7789665207"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f593be9f-501d-42c1-a6a9-316abbd1b170"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fb7ed84f-5aca-41e9-8d8c-ef5a4bd6c68e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fc82c8b4-af0c-49c0-b5dc-542c618f87a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fd43f104-04a0-45e3-85b7-4bcfd1e5e8c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ff89ee6c-7dc5-4ba7-ab8d-0c12530e8177"));

            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "Images",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PublicID",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("036b0775-1db2-415f-9e30-445412b4c591"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("235027f0-f01a-4210-b205-fa31477ef4f7"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("422e906b-643d-4a34-a874-bb865630fddf"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("adecaaea-6ad6-4651-be18-d484c90cfc39"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("b6425a89-41ed-4858-b379-735036e124c6"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("b6de294f-aaad-448d-8e2b-d5101a6de274"), "xe 5 chỗ", null, null, "SUV5", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("3f201d83-1d0b-467c-83a8-e8e8a8da5615"), "1 Year", new DateTime(2023, 4, 2, 22, 29, 43, 948, DateTimeKind.Local).AddTicks(8144), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("baf40be6-7951-4ecd-a8aa-132966fe192d"), "Short time", new DateTime(2023, 4, 2, 22, 29, 43, 948, DateTimeKind.Local).AddTicks(8132), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c457e907-f32b-448a-ae3d-cf64907011c9"), "Half Year", new DateTime(2023, 4, 2, 22, 29, 43, 948, DateTimeKind.Local).AddTicks(8141), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("066027ee-0a9c-4dc1-96b1-afef8091bbd4"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$xN/i2vkP6c7jlD1IfiAqW.fh1Msi5gwfrIiZR5TbTxMMPK5S6k2Y.", false, new DateTime(2023, 4, 2, 22, 29, 33, 180, DateTimeKind.Local).AddTicks(7020), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("07452669-eb39-48c9-8a9a-456bb682c06e"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$LmJT0xmor0DGmbbbJTC5o.WtY3N0Ptso9gmvz1XvW3rQEWX2pPdzy", false, new DateTime(2023, 4, 2, 22, 29, 37, 179, DateTimeKind.Local).AddTicks(310), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("09877103-2ff6-45f2-a9e3-e3c8676e6bd4"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$veG2WMISSXjx9SdO6IxQ3eEhEVBFCipT8N07KH2.XbJuxmhpMuyrO", false, new DateTime(2023, 4, 2, 22, 29, 40, 580, DateTimeKind.Local).AddTicks(9931), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("12c9f1ba-2065-49d0-b58b-18fe6e08bdfc"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$iOs1bEBhcir1vBiRV20fOuyU7cpKcylDiFa7cCsmrW55XjBuZ.UKG", false, new DateTime(2023, 4, 2, 22, 29, 42, 296, DateTimeKind.Local).AddTicks(8809), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("151a6730-13e3-4fe8-9dac-05a768856cef"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$wGQf6L27TMiDISdg6I/1G.9JrPlAq4gq.K6SFGIEluvY1B/gjO9KW", false, new DateTime(2023, 4, 2, 22, 29, 40, 197, DateTimeKind.Local).AddTicks(7904), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("17353aa3-1d26-4eca-83df-9f0948f38e40"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$uhL6jDywrKMax85QWYOIuu6SeplqtDSkZ6Hnr57aYvMJiNAbsq.tm", false, new DateTime(2023, 4, 2, 22, 29, 40, 459, DateTimeKind.Local).AddTicks(9128), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("18151f18-e8d2-478d-8f51-a90463e4c3c7"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$D/ajx4s9GAPBV.WiF3ldyO5Uu/ugqdhduCH8GgC7b8tjGFsvm6B/S", false, new DateTime(2023, 4, 2, 22, 29, 36, 83, DateTimeKind.Local).AddTicks(4795), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("182bff30-d291-423c-9215-618f3d8f4ef2"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$Q7iQqqU.WjiY56xIquCQdu/Vae9gtfYG2RjjCNzJ6t5enMrjIeUwq", false, new DateTime(2023, 4, 2, 22, 29, 41, 714, DateTimeKind.Local).AddTicks(2648), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("1e92001c-6cf6-4c39-847e-963bccafedb9"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$ZUVM03h1jDeEcGST5a3eXu.8suEwYZBMp4UdrBIwu5f1Cz3vyBNRa", false, new DateTime(2023, 4, 2, 22, 29, 43, 439, DateTimeKind.Local).AddTicks(693), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("20e3f00d-32ed-43ec-998a-6f0e731193a8"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$iVXRveRPuhqZFerH/j2Va.5ahMsYUF6GJYohqlliB6uchZSWrfjWu", false, new DateTime(2023, 4, 2, 22, 29, 31, 536, DateTimeKind.Local).AddTicks(9146), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("23305bc8-b14c-441b-bb13-4e71ff48c13a"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$KNoQiajB9VsdIWilpgqnQOC3PcNQPmABECJ1hD/NJ3T1ZbT6M6VwG", false, new DateTime(2023, 4, 2, 22, 29, 38, 854, DateTimeKind.Local).AddTicks(4547), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("24b1430a-9cb7-4ec2-bdfc-cef49458698c"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$QYL5A83RLsph9s3ZO5fW8O2R7dGE/T0zrUOOd5mfUiWpzWD.il8ca", false, new DateTime(2023, 4, 2, 22, 29, 35, 68, DateTimeKind.Local).AddTicks(8644), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("2810958b-4099-4554-abce-68c9345ee5f8"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$c/HMd0U5dSeXece46fGNw.tR2grnJNayPsB30/9bX5Bpaf4TOi3ra", false, new DateTime(2023, 4, 2, 22, 29, 39, 526, DateTimeKind.Local).AddTicks(5913), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("2a1c598b-c355-4392-bfb2-9e70e17fabb2"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$7ADst6fWkzLasIUtm8Zn4eHlfR919EmSdZHPtSIOLxMOYFKwtKdQW", false, new DateTime(2023, 4, 2, 22, 29, 35, 178, DateTimeKind.Local).AddTicks(4671), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("2ca8d718-c565-4c4f-b8b7-499338202524"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$huEsGz4vGnX4k8C05ty5XOeOLk5lbKQPuVu7x.IcoyiSQ1JPzmAxe", false, new DateTime(2023, 4, 2, 22, 29, 41, 829, DateTimeKind.Local).AddTicks(3013), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("2f15f436-3a0c-42e5-8576-9b102964f6a2"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$J1iL88RIWdyHJUYTtqDwNeLgvPwhbja8EuytELt4.6beQkV.T2rwK", false, new DateTime(2023, 4, 2, 22, 29, 41, 511, DateTimeKind.Local).AddTicks(5099), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("2f19834a-acef-4f1d-b8b8-d87dd1903d53"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$VRxPuht0aQCNUBwU3KGANeJ0knqxFF446lLD/8MOH6fV0qGL2mxv.", false, new DateTime(2023, 4, 2, 22, 29, 33, 518, DateTimeKind.Local).AddTicks(8537), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("2f55f4c2-5f18-45f9-b4bc-aed87b3f53ec"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$pvJXCZnLKuA8p0agHwwO0.R22GNvYDht2TcOb9WC9eFdUfv5ZeNGm", false, new DateTime(2023, 4, 2, 22, 29, 33, 77, DateTimeKind.Local).AddTicks(5931), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("2f5b4ace-9f00-4cdc-99f9-4552c5ce955f"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$3cPzrU6V688SQkv6jc4UK.jIi6Ov6.ed0xRKdZ/T7Rf73gExMzXJ.", false, new DateTime(2023, 4, 2, 22, 29, 32, 860, DateTimeKind.Local).AddTicks(254), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("317e6101-778a-45b2-a41a-ac5202723ea7"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$DTkFuVQYBOrZcuR0IltJ..Rcu263wLRX7m2j1Y75j8eiM1jB3pa4i", false, new DateTime(2023, 4, 2, 22, 29, 39, 997, DateTimeKind.Local).AddTicks(1542), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("33ef5de8-cb69-4227-bbf5-ff37ebd94577"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$LYoLG8w7dmcdC2q.cixONeLyyYgeI0Tq4gVg75RRvxU0YR8FZ2cyi", false, new DateTime(2023, 4, 2, 22, 29, 39, 333, DateTimeKind.Local).AddTicks(8550), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("367c6682-07b6-459d-8443-83ed23968116"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$4k6SwOQC1CcVHPO8wFgxnOaOMkUIAv4j8tLCgEO1H1O/FMUxuvJwK", false, new DateTime(2023, 4, 2, 22, 29, 31, 667, DateTimeKind.Local).AddTicks(2694), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("3a7a51df-d813-4c47-9e70-891b0d573c3d"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$roCGZZYnSzGxouW.aULDOuijgrgj4KSlUMb7TZwIn62JzF5oHi64C", false, new DateTime(2023, 4, 2, 22, 29, 32, 490, DateTimeKind.Local).AddTicks(3679), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("3d1ab949-8a99-4a9d-aba3-fe5464c0350a"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$eiPmZfeq3uIr9/l75cqgk.vT/3xisPVn3xzVIlkcGKF4TtZK4oGNK", false, new DateTime(2023, 4, 2, 22, 29, 38, 136, DateTimeKind.Local).AddTicks(7236), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("4a4d7cfd-20de-4471-87ca-54acc928ee8e"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$XxzmwSV6i2hUM4g8PdLQo.6KYrZBfWXyFxRD.deOLp/oHkfmEFxj.", false, new DateTime(2023, 4, 2, 22, 29, 30, 971, DateTimeKind.Local).AddTicks(8330), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("4b3e75e5-e070-4582-83da-00df741b9572"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$8.9kOql.ZNSsKc8M1W/yQe50cnrTbT/DT4jCHAguf5SxHeB0XnSS6", false, new DateTime(2023, 4, 2, 22, 29, 33, 318, DateTimeKind.Local).AddTicks(9719), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("4b5abe39-1e61-4d12-8630-f51af0e10688"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$FH4ukyu8wvo1aiNvymJtqu6MIKtnATuTEdTRtHm5D27wC3vrEBVwi", false, new DateTime(2023, 4, 2, 22, 29, 40, 977, DateTimeKind.Local).AddTicks(9733), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("4cdd7559-9e2e-4653-b01c-94512452b038"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$1ytLL/LSy2IyiQ3zIMnqouEu2zqXtCNmwppT5MBoov.qaR6jH13vS", false, new DateTime(2023, 4, 2, 22, 29, 36, 904, DateTimeKind.Local).AddTicks(9399), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("5273810c-5e2f-46a9-b8b8-5b8ce4901a31"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$FM50SjWWsrLdpYH.i5o54ONVKg7MRdHgbV/i.4r.JN5qLPOeIdFPe", false, new DateTime(2023, 4, 2, 22, 29, 38, 753, DateTimeKind.Local).AddTicks(6411), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("544b7905-3bea-4096-b0c6-24a0380a3562"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$3h.lXfAT5IrS9yNLhD1el.HAue3E8TfbRV0gSUVQC2UaLZG8A3jq6", false, new DateTime(2023, 4, 2, 22, 29, 32, 980, DateTimeKind.Local).AddTicks(1659), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("5459b155-a04c-4396-93ae-28a8e8986829"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$7th3X0Zu/Ov9f.pO6f/qyu7DWv4k2WMOLMaTpmfxsorZgOpWeVqCe", false, new DateTime(2023, 4, 2, 22, 29, 35, 653, DateTimeKind.Local).AddTicks(1280), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("55143f61-738f-4472-8cea-1298b31e3eb0"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$KVpHlzOp5o6nAWWcOPjtfOSaqbXctwYenqfOpCN.uNjnNxj0yZa4W", false, new DateTime(2023, 4, 2, 22, 29, 41, 408, DateTimeKind.Local).AddTicks(2976), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("55cccdc4-afee-4be8-ba4b-7b92494eb6e6"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$CaRDC0upWTtSc.LcK3Y/3uEIzoHjOsPsdnfFInu95H9/8QTLMz1PK", false, new DateTime(2023, 4, 2, 22, 29, 32, 362, DateTimeKind.Local).AddTicks(9831), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("56170298-ab1a-4df7-8752-94cc7631a482"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$TSZGwzvF/7r13C5MVRpnYOu4EKMQBWSv2NJGhbQUWPKEkb3PWk2im", false, new DateTime(2023, 4, 2, 22, 29, 33, 875, DateTimeKind.Local).AddTicks(5154), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("575232b4-ebf7-4738-93c3-81f61d87e642"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$4i8RFcn34/Hxn5o8em5Uguga0WwPNqvt9WEyFGl4RMK.2T/XzRXUC", false, new DateTime(2023, 4, 2, 22, 29, 41, 208, DateTimeKind.Local).AddTicks(5163), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("587cc5f4-5e81-4ad5-9b29-5eee1b840231"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$N7N63ZL6elYgjPWm8UugJu.eXL1tL7QLnKoMp7AA.0tlRXHOUQdtC", false, new DateTime(2023, 4, 2, 22, 29, 41, 312, DateTimeKind.Local).AddTicks(8457), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("5976f734-9d71-457c-ace7-13a621e71b72"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$hc0lxH5tkJ4G.wWHs1jAYOliEa1t32.WuN/1Mjak4NiaHUOjPL4Ga", false, new DateTime(2023, 4, 2, 22, 29, 38, 975, DateTimeKind.Local).AddTicks(6345), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("5a55cbc0-b5fd-4f94-838a-a9d4d28337f4"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$drAdIXEPFgicpXN7dp7U9.cv6ZOdMK8wmhFPTBCbYdxS7HIDfc0tW", false, new DateTime(2023, 4, 2, 22, 29, 42, 884, DateTimeKind.Local).AddTicks(5702), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("5b37529b-7d4e-403a-8dd0-1567e17f9d98"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$2pmqHJFyrVTMH.rPp0x1zudDpublGd27wZLzmPR3pZos3x.vzHese", false, new DateTime(2023, 4, 2, 22, 29, 32, 715, DateTimeKind.Local).AddTicks(5652), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("5b4dbe05-a450-4606-9412-7b7a4a8c2feb"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$TTmX9ZkrOOfNJLKgU9UFgOVc.Grcz1NW3zqL1Hjas7bcy.y/n/492", false, new DateTime(2023, 4, 2, 22, 29, 32, 19, DateTimeKind.Local).AddTicks(108), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("5ba13129-b847-4a65-a740-a9f36025b1bb"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$rdwe/GDnQWjtLJwrNu1U8OhhChRlTODaUkcSY0uQVRAosbsqgmsaq", false, new DateTime(2023, 4, 2, 22, 29, 39, 645, DateTimeKind.Local).AddTicks(7971), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("5ba4ad85-3344-4c9a-968a-82d384fc91df"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$rWgV5pmkOh6k.p52q2FFqui6uu.5wfz6lOl7dCurTfCVflCWnlvga", false, new DateTime(2023, 4, 2, 22, 29, 34, 73, DateTimeKind.Local).AddTicks(5679), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("5e4bc7eb-13e6-4f19-aa50-0ec23234c27f"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$IRmkFYLn6tlihERKII.KH.cUjm99V/Iojn11YDQWdW5O4wLDNS/6O", false, new DateTime(2023, 4, 2, 22, 29, 34, 533, DateTimeKind.Local).AddTicks(9034), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("5e5ec6c7-6d6d-4c5f-a295-57f33f1f8974"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$GYKnizoW68VCppv4EV0e9OT/CyYFuknK3CmP.ysLundqjEqYHaU3W", false, new DateTime(2023, 4, 2, 22, 29, 40, 96, DateTimeKind.Local).AddTicks(7805), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("5efd48ea-1ca1-450a-a923-ae9e869318c4"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$2K2E23FZcOMNq8/lvX8EHedhZgU3fpqIXMmOZVrZuwhRBj2I1FbN6", false, new DateTime(2023, 4, 2, 22, 29, 42, 772, DateTimeKind.Local).AddTicks(6187), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("643af74b-468e-4a38-900c-4332aa23315d"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$BXak1lSsWZFHemSD/ewF1.WbsCudkuu.LRq2Y6FGTVAlaTZErEzfC", false, new DateTime(2023, 4, 2, 22, 29, 35, 943, DateTimeKind.Local).AddTicks(3026), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("66b84bf2-eada-4fad-9542-6bf49fde75c2"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$RVbwB4F7ED4nl08yW46FzeWommRoEcYyeZ8tkXLh4Lew7Kj5pbNo2", false, new DateTime(2023, 4, 2, 22, 29, 39, 758, DateTimeKind.Local).AddTicks(2409), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("678b0d0c-fd82-43bd-96ae-eb574541e78d"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$2/OJFWaqzdNcNxdQpKy.EulfdrG76l0w/qPNeir869dQ8IqhU9KDm", false, new DateTime(2023, 4, 2, 22, 29, 37, 656, DateTimeKind.Local).AddTicks(4486), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("71bac348-5faa-446b-a269-7befe3ef24ad"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$5/ge6pqIsDpyABMjMCx//Oh2dTnNUYESQspqrydhqBMIcGrY23MEu", false, new DateTime(2023, 4, 2, 22, 29, 41, 101, DateTimeKind.Local).AddTicks(1825), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("725c5b89-e278-4ce1-a1d1-064c3e6ae5cf"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$39Xtuum6tnWKdguil653PuAQVLuM950tU5oL/c78sZg5JieBjQkJa", false, new DateTime(2023, 4, 2, 22, 29, 37, 37, DateTimeKind.Local).AddTicks(112), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("726541e6-cc1f-4b28-b019-48294a14cdb0"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$QZLtnUZ3R86CwdZpERzxhe5U92hfw5B06zeNdb9/cGXbmy5xNPLCO", false, new DateTime(2023, 4, 2, 22, 29, 34, 947, DateTimeKind.Local).AddTicks(4275), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("7ad57d1b-e77f-4d05-9757-b8b0ac0b4d6c"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$tvkdRHxIk0BWX/a2hmqY.uE3MMliPYQNXxs0QnjoT0j2WZ0C29zh2", false, new DateTime(2023, 4, 2, 22, 29, 40, 781, DateTimeKind.Local).AddTicks(9855), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("7c9b181d-63fd-4a19-8659-a3e45ec700e5"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$X/Ta7ANMl2CiI1LIyoUaFuPljLqWJqmOFyVPcKiOCOZkVMWxjyYp2", false, new DateTime(2023, 4, 2, 22, 29, 35, 803, DateTimeKind.Local).AddTicks(6925), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("7dee1cb1-16c5-4911-ba17-2c2651343d26"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$KfPdlE/Mc0pnhHF7RByCPuG6Qdl0t0.3WbMO.TH3n9ZFd71q3OI0m", false, new DateTime(2023, 4, 2, 22, 29, 31, 902, DateTimeKind.Local).AddTicks(197), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("7f992492-4177-4f8b-a10f-9beab1a43408"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$XyJ07IooGzdxUfZRpt8UY.QeSvcvYlL.ES.zghsXzXV.uRxRcRym6", false, new DateTime(2023, 4, 2, 22, 29, 42, 635, DateTimeKind.Local).AddTicks(4832), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("8998c954-c712-4598-bb79-0c638b2e71c9"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$ijNkJKQK091CqGn0T3gY1.rjb2Tm3cvdBCRZfMAukXp7071naabUi", false, new DateTime(2023, 4, 2, 22, 29, 34, 172, DateTimeKind.Local).AddTicks(3116), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("8af35b0e-7430-4dab-93b7-a5cf68a836d1"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$R0xwT1I4xmcqXKcdlzWRmuoGQaKhbkLmmwjt3cY.cb0u9T3ZpEQSa", false, new DateTime(2023, 4, 2, 22, 29, 38, 273, DateTimeKind.Local).AddTicks(8099), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("8ce07fce-d8a9-4519-9dc6-b6e1ca6fc743"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$gqn3F.XnpKzW0ORPXI5dWOVAECvNPqriOohvlZW5j2XWuToMIuCiy", false, new DateTime(2023, 4, 2, 22, 29, 37, 292, DateTimeKind.Local).AddTicks(7623), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("8d1c0218-2135-463f-ab2d-4b8ada05b3fe"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$JsvhJNP4YN9ifuZqKf5esuZuhVoh.gvSbQgTa.FPy2.9sx0GgaJZ6", false, new DateTime(2023, 4, 2, 22, 29, 42, 406, DateTimeKind.Local).AddTicks(9844), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("9007b506-c63c-4185-a97b-6f8365d70d56"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$sBy9NQ7BVZfPHguZfEBFj.Gsw/8xSDPJ.TE7ARyePkc.PTiGFE/2y", false, new DateTime(2023, 4, 2, 22, 29, 38, 18, DateTimeKind.Local).AddTicks(1811), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("92b3bfeb-9453-41ec-bfc0-80389ac7d96d"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$/LuRXt3tCWHcKl/J9K8shOtVzikJXL1RiVr9jmledJJOgHJ82zF12", false, new DateTime(2023, 4, 2, 22, 29, 37, 779, DateTimeKind.Local).AddTicks(3714), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("938ed42d-ecab-432e-9cce-f4481c852136"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$bC5CJmgA8vF/4gqxd3qBXOMTwvq3.MS5732u8n5VbCX6Iv4NIuYKq", false, new DateTime(2023, 4, 2, 22, 29, 43, 335, DateTimeKind.Local).AddTicks(6355), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("9818e7c7-bbcd-4e97-a81c-8728fbf5a2f6"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$DDhsaSIe/Q5VXHposs5Mb.zO4G8flZcNgstX./cnniza/22qnHjB6", false, new DateTime(2023, 4, 2, 22, 29, 32, 607, DateTimeKind.Local).AddTicks(4257), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("9eb85694-0a33-455b-9f7d-5bfaea3264e8"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$pxSo2OkQjRr6zLKxnjLLi.A1aYOBXhYxj9wBC8Qp/55KkuHP4UDb6", false, new DateTime(2023, 4, 2, 22, 29, 33, 772, DateTimeKind.Local).AddTicks(7789), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("9f6f38a5-a023-4e0b-a393-a7d080bae76b"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$7qg4kq6C.sdXt89QY9t02uLQihQplgEOU2CjhvdJisjPz/82tujlG", false, new DateTime(2023, 4, 2, 22, 29, 35, 303, DateTimeKind.Local).AddTicks(651), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("a0c676ff-f47d-4db3-946c-b093ffab51b0"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$F8NvBKvl4J.RAWpAFfKJkuoYJHXggfQM9L624H/ukLCNeOVpZ37G.", false, new DateTime(2023, 4, 2, 22, 29, 36, 235, DateTimeKind.Local).AddTicks(113), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("a32dbc0b-282c-46aa-a5c8-40f6c90cca59"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$okL6jURNeiyHysjZa.hf..bR6VYNedBahEvVptV6tkZCFtdogS7Ce", false, new DateTime(2023, 4, 2, 22, 29, 36, 643, DateTimeKind.Local).AddTicks(7086), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("a83247f4-2c72-4943-a23b-8dd7a19fb96a"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$WdtKtImRHlSJ5fkgDF4E5OaXYdQNH7PTxXkez1hXRTj5DKHtdSic.", false, new DateTime(2023, 4, 2, 22, 29, 42, 989, DateTimeKind.Local).AddTicks(3443), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("ae1b702b-cd09-4b20-853f-040fa6a55d63"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$kmr9pmrLqlq8/wB/5x6oqu5Dj.bkJfzsyykB0T.sZNykcO9dvr5Sy", false, new DateTime(2023, 4, 2, 22, 29, 42, 173, DateTimeKind.Local).AddTicks(4550), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("ae9e6364-b0bd-4725-83a3-11f1b933525a"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$QDq6r/BpbB53Rv8JzAm7.O.Ei9P08agl7wEUmpYlPvxoFBnBCAzum", false, new DateTime(2023, 4, 2, 22, 29, 36, 517, DateTimeKind.Local).AddTicks(3102), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("aee9366a-8e47-467d-81b5-2c37eba21f9e"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$eDJ6ije9J2x8rm3Z48CL1ehCqEeom.PjHyQ/ckF..QtIpdHwKZP2i", false, new DateTime(2023, 4, 2, 22, 29, 35, 532, DateTimeKind.Local).AddTicks(5402), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("b0b4dc57-dc52-4ab1-a13f-1ec55020c4a4"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$FDwyJeoInGho5Fc09ykjTu8U39jv8eIU5itm7nfRJiRHJ/EGFIkiu", false, new DateTime(2023, 4, 2, 22, 29, 41, 948, DateTimeKind.Local).AddTicks(4345), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("b2657840-26a9-44dc-adf4-eab10a198ae2"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$0P0YGA9WuRiCrTRDAlXuHuYAlsaGQdc9ptTZO.Z9RP0opR8xQRB6G", false, new DateTime(2023, 4, 2, 22, 29, 35, 425, DateTimeKind.Local).AddTicks(4492), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("b2deaf69-7c23-4415-ae6d-9390250d2012"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$I5I0TTMcqXjCUXjVyxJdoO23Cb1fm2c6X0DfiZXoBKJHnnPRuT9pO", false, new DateTime(2023, 4, 2, 22, 29, 43, 948, DateTimeKind.Local).AddTicks(7440), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("b34b0862-2391-4ed5-bc2c-98bfbf465c6a"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$p7izoYxR/wx0T8.1bjNms.02U9O5xliXDr76NuRxK9zxTa2Qld16S", false, new DateTime(2023, 4, 2, 22, 29, 36, 765, DateTimeKind.Local).AddTicks(7106), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("b49d1b0e-93cd-4539-a3fc-49eb8bbc6844"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$Ek35t4l7QuJx2GGIaPfk3.woQFSz8s6VFqXiR5TU0iVgGJa19Nn26", false, new DateTime(2023, 4, 2, 22, 29, 33, 978, DateTimeKind.Local).AddTicks(777), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("b618e251-a8fc-4d86-a3f0-c2c04a9bcae2"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$Gv6ch5CRQF6jg5dWMuFec.AEQKG/u.wZ3Xv3Wk8RJhWZ9IokY4vXO", false, new DateTime(2023, 4, 2, 22, 29, 32, 256, DateTimeKind.Local).AddTicks(7636), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("b8720570-58a7-487e-a69c-dcb1606e0ef9"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$JFSMYPfmv0EQEmMQWDOCM.yyq56ze0dREzVIIeuTXuTw.FISqCTnS", false, new DateTime(2023, 4, 2, 22, 29, 32, 144, DateTimeKind.Local).AddTicks(7690), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("b99343a6-c37b-4b5c-8f89-c627ade99cf0"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$cRhtpb3niW4am3uXAO2fIeBHNYJCG.B.34zP2gG3FUgBjKigYq2ae", false, new DateTime(2023, 4, 2, 22, 29, 33, 635, DateTimeKind.Local).AddTicks(7050), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("bc6fba10-f393-4c51-955b-8af37098af44"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$CnJmWTLAVc5xpfq.UZlGM..4xQXRpFCENIXRytbeHodx.yrylUFpe", false, new DateTime(2023, 4, 2, 22, 29, 31, 784, DateTimeKind.Local).AddTicks(39), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("bcf32d5c-e217-4c9d-9d3b-e27a2c7e2b82"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$X1LVHcnZU83vul5acV7D3.p0C5kVbKbFCBwdaBOvRb8J7TlQ7uhNu", false, new DateTime(2023, 4, 2, 22, 29, 34, 292, DateTimeKind.Local).AddTicks(2390), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("bf61e520-7c27-45e9-adf9-4ee11bac0290"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$8CjMIxxsZ07Rl1bQGqQZm.Sxpc.DTeyKfNgLaCtiolrN1oAxH7S3.", false, new DateTime(2023, 4, 2, 22, 29, 39, 233, DateTimeKind.Local).AddTicks(3128), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("c2e40f7e-5c97-4d96-b7e2-0595364757f0"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$qaMEvD1Put3rRw2FKoSqSemVflRPtm3B4NHgvtNLKb.7VWW2peX06", false, new DateTime(2023, 4, 2, 22, 29, 39, 430, DateTimeKind.Local).AddTicks(5513), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("c3c501d6-f73d-453b-9bc5-1f587b733d65"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$B51.crltO4ETX8J/8hG1fOOy5d3U4vnruRjz4.jJVb33djR2gcJie", false, new DateTime(2023, 4, 2, 22, 29, 34, 665, DateTimeKind.Local).AddTicks(846), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("c42b925b-9619-4fc3-8029-ff673bb05bc9"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$jfw1MBZ.9wOq7bUFINzgJ.5S1yyRuO6pxThIHPAkDR9Ml9Mf.k2sK", false, new DateTime(2023, 4, 2, 22, 29, 39, 866, DateTimeKind.Local).AddTicks(2412), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("c45ba6bf-e7d7-4497-8d07-55f21a38edf8"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$VVbWLIibSBjMPimZ4MVjcuhLNDMUVtgtXqgGpcK3mBWzUE1926X5a", false, new DateTime(2023, 4, 2, 22, 29, 37, 407, DateTimeKind.Local).AddTicks(9620), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("c4d8464d-db65-4880-bdbd-4d810efac509"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$xwaIp25F7IQaoNXdtQs94O7Cd6JVfwz9BeOuWpHepLhTO7Ff0KHd6", false, new DateTime(2023, 4, 2, 22, 29, 30, 853, DateTimeKind.Local).AddTicks(9592), " Nguyen Van", null, null, "0966416708", -772000, "customer" },
                    { new Guid("c8c5e629-f8e5-4324-9fac-546375f67314"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$eGP/O/fUX8cgMmKMVGai6OHUD9pcr2CHXE1zZLglTxNMj7JmsKkCi", false, new DateTime(2023, 4, 2, 22, 29, 30, 725, DateTimeKind.Local).AddTicks(5959), " Ass min", null, null, "0966416708", -772000, "admin" },
                    { new Guid("c8cfd9b2-9901-43ec-b04b-7ae8bed88ac2"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$GDBgesaPy7XpZ58PRtJ8LucF3x4vJ7SjlEgD5oRnA1T2GtrxwfPmu", false, new DateTime(2023, 4, 2, 22, 29, 37, 890, DateTimeKind.Local).AddTicks(1543), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("cb103b6b-75c0-4f25-ae41-d4e3cc582fd3"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$SIbSPtg0INwtWm50Oi45Auy4LfcfMHkl./BgbGuohnfzmeBdmL52a", false, new DateTime(2023, 4, 2, 22, 29, 43, 732, DateTimeKind.Local).AddTicks(8228), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("cd9abcc4-84f9-4624-95dc-1760b5fc51e2"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$hu8C0YOTib64OurogXG.e.cBWrJGwPD7N56SXSWFDzBzkDf8qPw4e", false, new DateTime(2023, 4, 2, 22, 29, 42, 60, DateTimeKind.Local).AddTicks(8776), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("cdced3f2-72fb-4053-9142-4830d46c1433"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$I7SOHdq0ExC4nSwuS7YkUuTcM4JFDqDeqaz0O7z3qNtoIWJ.GPF8i", false, new DateTime(2023, 4, 2, 22, 29, 31, 430, DateTimeKind.Local).AddTicks(7420), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("cee75063-928a-4d43-997b-5b304b98b307"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$lue5DGn6I65ePRnfbYqOl.vAyIidw3r0FczRQCFqf5q/iKX5urUX.", false, new DateTime(2023, 4, 2, 22, 29, 43, 842, DateTimeKind.Local).AddTicks(2337), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("d6665762-c2b4-4195-a9b7-6fc17e686b52"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$4ASD6HWhJs3ABk74V4sRieVFeP.e9Y586uOxALZkCA/PGZvmzolqa", false, new DateTime(2023, 4, 2, 22, 29, 42, 525, DateTimeKind.Local).AddTicks(1381), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("d6a9bf93-e762-457f-989f-cc5154f0d2e3"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$Nz27V.4rpdpp/WJ/j8PMPODhr12torSDNuKjjz42iiYu.jP.jLwXW", false, new DateTime(2023, 4, 2, 22, 29, 38, 524, DateTimeKind.Local).AddTicks(8639), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("d99c2954-e294-4c83-aaae-a7143c982156"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$rNC5fdF63/U29/2fxx6Y8uH2RiVaDBOrCgpqV2IRs5N9cmLZ0g2Bi", false, new DateTime(2023, 4, 2, 22, 29, 43, 576, DateTimeKind.Local).AddTicks(2139), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("dad93d2d-8798-4cf1-908d-9cd1934277ec"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$4XKgcwtkogOaYTxmdv.NzeziTOoCWOuwpKtZx4BPSWjXTq.W4rILa", false, new DateTime(2023, 4, 2, 22, 29, 40, 337, DateTimeKind.Local).AddTicks(3356), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("dbf0deaa-b002-4180-9129-bc0008e8bbfe"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$W5hHCcPNgmMA2sNhDN3jj.J2vioaCDYuFDo5WMbVbiz.H.9Gcyl2G", false, new DateTime(2023, 4, 2, 22, 29, 40, 687, DateTimeKind.Local).AddTicks(9394), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("dc62e0b5-5f7a-4ce0-ad06-d1dcf3c982dc"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$4SvwW2XGi7IAMefYwoyD2.r9.7DD7osEi9DCHTYWMeXF8RGpPOlQ.", false, new DateTime(2023, 4, 2, 22, 29, 34, 413, DateTimeKind.Local).AddTicks(1323), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("e022a049-4ada-4c8b-a52d-c96873c768de"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$qDcrf7UqglFd7V0JRSvhiOaKtatXAHO62hwqv8FQCfkDmIYpd4fue", false, new DateTime(2023, 4, 2, 22, 29, 38, 647, DateTimeKind.Local).AddTicks(1904), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("e59aab6d-a277-44ec-aa8c-48f40c0adbf8"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$AefNu6qyDX2V6WytSFwoUO2cs6llOF561s.Vcbi72n0rPXQgWfMAa", false, new DateTime(2023, 4, 2, 22, 29, 37, 536, DateTimeKind.Local).AddTicks(7932), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("ecde6a14-af14-4adc-8b1b-7d5c8aafb113"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$fo/k/8YXJ9s35O5spaYMv.aGhfLg2m7uqcQHOeGvg30hdxsiEa.Re", false, new DateTime(2023, 4, 2, 22, 29, 41, 616, DateTimeKind.Local).AddTicks(848), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("f07b9f22-9c3b-46bd-9501-fe6cad24012a"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$lYDzBvDrNCZLp9NzeFjeo.B/HSPbf8BFqy5REWwCy5ZTPMYaizQvS", false, new DateTime(2023, 4, 2, 22, 29, 43, 101, DateTimeKind.Local).AddTicks(3421), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("f132bb1d-a37d-4e7d-b937-e73c4b10c3b8"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$m4O1gHoNnLf.9otQfNbpe.nfBqZQ9RI96IxhSUnbis1erfKxZnWNO", false, new DateTime(2023, 4, 2, 22, 29, 39, 123, DateTimeKind.Local).AddTicks(7395), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("f1edf458-88c0-4f56-aed4-4217ac0531a1"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$Pnj8L65MLu3oXGb0sj5I2OUyHlxKWJkp3py3JwvKy18Z.4LCS5wj6", false, new DateTime(2023, 4, 2, 22, 29, 33, 419, DateTimeKind.Local).AddTicks(1627), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("f20a5c2b-65c0-41c3-bf6a-2029fcf34ffa"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$0GYvhOwkNwydCJrxuLwE9OqhZ/flSUrhE8LKEmzE3YVLC70XurYBy", false, new DateTime(2023, 4, 2, 22, 29, 34, 805, DateTimeKind.Local).AddTicks(5947), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("f2fba7b5-e424-4fe0-9f42-5c394b7d1fa3"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$A78sjNLqFAQiwXpPr6EUF.FSuc.2KYdHqgaEOV7OyqvCxyCaRk/Xq", false, new DateTime(2023, 4, 2, 22, 29, 30, 579, DateTimeKind.Local).AddTicks(9573), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("f486b9ff-a4ff-4dfb-9b52-1cf77ac9a6cf"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$MoW.KI1Uwbvc5LHri2AKHOKLHKFIBQ7MWX3vOsbjRBYDbJEoJZUBa", false, new DateTime(2023, 4, 2, 22, 29, 40, 877, DateTimeKind.Local).AddTicks(1534), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("f4fa0f96-37a5-49b0-9143-2a223751c802"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$sINeSFlqRQKu98tPacKm.eRiNFM/n34mMYuobbIlqkNIgenj76StK", false, new DateTime(2023, 4, 2, 22, 29, 36, 359, DateTimeKind.Local).AddTicks(8049), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("f5f0a321-362e-4c18-9e39-1ed3065d3b80"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$UbtIgashWcTVfWUUGEI5rOFxkJemHq6HUg3oT9ZJYxuh7uEDJVbXG", false, new DateTime(2023, 4, 2, 22, 29, 31, 302, DateTimeKind.Local).AddTicks(4824), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("f6c0b28c-69a0-4f3b-b181-d9abbfde4150"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$vNiCSpqN5V6/3fZdOZXAPOjD3o.On4r4hcu/EkgcgVytt/wkPDK.C", false, new DateTime(2023, 4, 2, 22, 29, 31, 80, DateTimeKind.Local).AddTicks(2738), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("fa78dde4-446b-4410-a2f5-6fadc0e3698e"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$K07u07XttroWTkkBORhxCuuBccrv4b3k.NS87yexvIjR2Vo67FD7e", false, new DateTime(2023, 4, 2, 22, 29, 38, 373, DateTimeKind.Local).AddTicks(4483), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("fbc87d2f-b489-409d-80b7-5694572242a4"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$ccFMiUKfixoY1O3tZWM.3OhuLsfQNslixVX0eGSicjtEIhY36VOFi", false, new DateTime(2023, 4, 2, 22, 29, 43, 226, DateTimeKind.Local).AddTicks(4068), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("fcea9a15-c1e2-4efa-93bb-002d27016dec"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$Hv927CL7Jxrt9JMwEONDEuBwTp949cg0.vseE7yiwBVcmrWrTG9Ma", false, new DateTime(2023, 4, 2, 22, 29, 31, 179, DateTimeKind.Local).AddTicks(5966), "Stewart", null, null, "07343082906", 1, "astewart2" }
                });
        }
    }
}
