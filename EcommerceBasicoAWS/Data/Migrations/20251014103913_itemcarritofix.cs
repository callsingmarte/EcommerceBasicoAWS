using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceBasicoAWS.Data.Migrations
{
    /// <inheritdoc />
    public partial class itemcarritofix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsCarrito_Carritos_IdCarrito",
                table: "ItemsCarrito");

            migrationBuilder.DropIndex(
                name: "IX_ItemsCarrito_IdCarrito",
                table: "ItemsCarrito");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e256a823-d66c-457c-850e-4c66ea6f9173", "51e5f7db-a9cc-4886-95e5-b9a5d5bed5e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4eb7fdef-aa3c-473e-94b0-1521fca6475e", "7f6ba682-5e9f-4f59-8805-1f5372d5f35b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71061cec-029c-4dec-b1f0-24828b683206", "d8e55bc7-cccf-4295-8193-44708d9c8710" });

            migrationBuilder.DeleteData(
                table: "DetallesPedidos",
                keyColumn: "IdDetalle",
                keyValue: new Guid("514677cd-56e8-4d03-ad5f-3513bcee8d0f"));

            migrationBuilder.DeleteData(
                table: "DetallesPedidos",
                keyColumn: "IdDetalle",
                keyValue: new Guid("b55bfb46-5cb5-4df2-b54d-67ee1ab2dc7d"));

            migrationBuilder.DeleteData(
                table: "DetallesPedidos",
                keyColumn: "IdDetalle",
                keyValue: new Guid("fdac9a7a-f6f2-46f4-8bc5-211bd6762cb0"));

            migrationBuilder.DeleteData(
                table: "DetallesPedidos",
                keyColumn: "IdDetalle",
                keyValue: new Guid("fdfb1d9e-cc61-4377-b322-f8f15e26e4da"));

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "IdDireccion",
                keyValue: new Guid("ec83090e-331c-4a3e-ac73-48e049b8665a"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("184c4879-5b84-47b4-af27-2c8260f15fd5"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("253cc766-74db-4933-8519-0754937e88e9"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("2d2ffcc2-9dd0-4878-abbe-00e9de78deaa"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("516af201-534f-43ed-9b28-6a326a303f10"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("5e077d2e-6a33-4d92-8980-9a8e2e4ff090"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("5e5db5a4-2491-41dd-9da9-464e7b5c5f0c"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("6b71d369-9edd-4012-b445-9693b884d7a6"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("7f77872d-7275-4edc-8a4e-a879d66e0c73"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("8325752a-6bd9-4e82-9c16-e59e97c3de6e"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("9974718d-39c2-4f04-9d9e-00019ea6b87f"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("c181869f-08a4-4ce2-aa45-9f599536568d"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("c4487414-5bc0-4f23-8ce3-e7794f1de576"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("ce27ed17-5d11-411e-b0a1-7706adf478ae"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("e5d0b040-f7d0-42c8-8330-42f6fdff3458"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("eb86f009-daca-4b04-aa88-828ed2c2615b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb7fdef-aa3c-473e-94b0-1521fca6475e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71061cec-029c-4dec-b1f0-24828b683206");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e256a823-d66c-457c-850e-4c66ea6f9173");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51e5f7db-a9cc-4886-95e5-b9a5d5bed5e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8e55bc7-cccf-4295-8193-44708d9c8710");

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("0199fb45-4f90-41f9-88f5-823cbecbbfc5"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("1e151a41-ab08-4f66-9c64-c3e95c97af47"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("24bf372e-8936-4fbf-8d21-81b91e7c9a25"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("4ee9ea41-0b2a-4a42-9637-b143034a590c"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("82252331-cf7f-4544-8161-d3c33cae4121"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("ba62943f-1480-4bdd-b590-f824b70fc1fe"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("bf395ed3-c1e5-4cbc-93f5-d73a880d5774"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("e7e3f7ca-5d40-4d23-8ffa-44a7aea070b8"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("e98f528d-99cc-4b55-b1d6-eda10ecfc879"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("fd312981-e795-403d-a31d-5a32077c0232"));

            migrationBuilder.DeleteData(
                table: "Pedidos",
                keyColumn: "IdPedido",
                keyValue: new Guid("0ed5d9ee-359a-4d79-9789-f796996554c0"));

            migrationBuilder.DeleteData(
                table: "Pedidos",
                keyColumn: "IdPedido",
                keyValue: new Guid("25054ab4-7ad3-4c5d-a3d7-d4c8105cc4e3"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("66b287c6-acd0-47e4-b0af-045cde2d6433"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("71bb098c-ee88-4b42-87a6-28058b5687c7"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("723863c8-1a7e-444b-92c5-a5933f9a7d87"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("90fa0563-17c1-4779-9fd9-ce313d115060"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("97bc96e2-dd06-40a0-8c98-c43e18d774c0"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("a7987e74-9e49-410b-a709-f472f93a298c"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("b8450b78-cd14-4e65-97ac-3649a55fd9a0"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("c464ef7d-1568-4ac8-8452-2accb5e78be3"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("cbbe008e-9d5d-4cf4-a4fa-2d2c910c9515"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("e0009b89-c414-4715-95ad-095fa75dc331"));

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "IdDireccion",
                keyValue: new Guid("f1f7ea57-94ed-4c28-b16f-80e2e2bb56b9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f6ba682-5e9f-4f59-8805-1f5372d5f35b");

            migrationBuilder.AddColumn<Guid>(
                name: "CarritoIdCarrito",
                table: "ItemsCarrito",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "256bce89-bbcf-47e4-9477-7a66547d8ba7", null, "Admin", "ADMIN" },
                    { "4e731712-6fde-497b-9e70-aabecaccd030", null, "Staff", "STAFF" },
                    { "95097de8-75af-40b5-b234-a8c9aeaf7fe0", null, "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "889c0e2b-ae82-4bcb-9fa3-25d3168f4c94", 0, "98f6ea28-9118-4d5c-938f-bf70e01eb152", "admin@nexusshop.com", true, false, null, "ADMIN@NEXUSSHOP.COM", "ADMIN@NEXUSSHOP.COM", "AQAAAAIAAYagAAAAEBTXZJWwZ1YhUNADxraViJrw3I5ZJ4NXay2JxrweLVny6FwMCVzSMARZPH1hpYns1g==", "653124875", false, "b8869316-6938-458c-9f83-27b461824438", false, "admin@nexusshop.com" },
                    { "c99cca50-f8d9-411b-ae3d-4a72729c073f", 0, "015a9c89-4073-4fb8-aff1-e6d72b854e79", "paco.montoro@gmail.com", true, false, null, "PACO.MONTORO@GMAIL.COM", "PACO.MONTORO@GMAIL.COM", "AQAAAAIAAYagAAAAEMy3OoklSXj8AwmO1TgWiP0ZiewcxMLwquv42Xiho7DnVCEWQfuOP+qw/ovzlqguYQ==", "632514785", false, "6ba924e4-3334-4f6e-80af-735b74eea4ad", false, "paco.montoro@gmail.com" },
                    { "fd2c6f23-c997-4bd9-8b4c-5492a5501323", 0, "3e05dd70-2f5b-4d9d-8142-e7baae079fcc", "lucia.sanchiz@nexusshop.com", true, false, null, "LUCIA.SANCHIZ@NEXUSSHOP.COM", "LUCIA.SANCHIZ@NEXUSSHOP.COM", "AQAAAAIAAYagAAAAEKSeWarRyxyMnBHWsHN6RZFIcS7QAOa/O780X66x9peTBd2269fOokoL2pyP34RXEA==", "685214739", false, "05b1b886-f685-4692-9872-de17453eeab2", false, "lucia.sanchiz@nexusshop.com" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "IdCategoria", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0d45e702-9506-4edd-80ad-3cc2fc1f3854"), "Belleza" },
                    { new Guid("0d5b18c3-d126-4850-b5fb-4b1e93cb2dd5"), "Joyería" },
                    { new Guid("0eb1115e-75ee-44ea-b5de-15bbe78da54a"), "Ropa" },
                    { new Guid("1a0781b7-629f-462e-8487-c410b1391f5a"), "Calzado" },
                    { new Guid("1f3f91c0-2666-4e5a-81f0-e6969f1f2707"), "Deportes" },
                    { new Guid("1f4c2afd-63ad-479b-affd-f4a9e4ca6dca"), "Accesorios" },
                    { new Guid("53fb44b3-7dfa-4c52-9305-6274c181d861"), "Hogar" },
                    { new Guid("554cf31c-afce-4a38-87d9-309bb8b32873"), "Libros" },
                    { new Guid("7432c6e6-5071-469d-950f-aaa1dd5144f4"), "Tecnología" },
                    { new Guid("8ddf324f-e2e6-45b1-91e3-e9a7fbb6f868"), "Electrónica" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Descripcion", "FechaActualizacion", "FechaCreacion", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { new Guid("0a0200e4-c1d9-4e7c-a268-9cf3a1b1797a"), "Reloj elegante con correa de cuero y movimiento de cuarzo.", new DateTime(2025, 10, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2851), new DateTime(2025, 8, 25, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2850), "Reloj de Pulsera Clásico", 99.99m, 30 },
                    { new Guid("1db3a7a5-9204-4964-8254-f4869406c51d"), "Funda resistente para proteger tu teléfono de golpes y arañazos.", new DateTime(2025, 10, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2846), new DateTime(2025, 9, 9, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2821), "Funda Protectora para Smartphone", 24.99m, 120 },
                    { new Guid("5b83a272-091a-49a8-9410-fe0df1050c7e"), "Auriculares con conexión Bluetooth y sonido de alta fidelidad.", new DateTime(2025, 10, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2957), new DateTime(2025, 9, 19, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2955), "Auriculares Inalámbricos Bluetooth", 69.99m, 80 },
                    { new Guid("824776e3-0cc8-4d51-8e15-22c0cc608e4a"), "Pantalón vaquero clásico de corte recto.", new DateTime(2025, 10, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2684), new DateTime(2025, 8, 15, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2682), "Pantalón Vaquero Recto", 49.99m, 50 },
                    { new Guid("a1c8c1c4-b461-41da-8162-5cca867f7f6c"), "Una emocionante novela de fantasía y aventuras.", new DateTime(2025, 10, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2808), new DateTime(2025, 9, 29, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2806), "Libro 'Aventuras Épicas'", 12.50m, 150 },
                    { new Guid("a253f3df-8fd8-45c0-b265-32b5f0986a81"), "Gafas de sol con lentes polarizadas para una visión clara.", new DateTime(2025, 10, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2776), new DateTime(2025, 9, 24, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2774), "Gafas de Sol Polarizadas", 59.99m, 60 },
                    { new Guid("a5ac44e6-d2ed-4bad-af28-cf9b5a4c34fe"), "Zapatillas cómodas y con estilo para el día a día.", new DateTime(2025, 10, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2742), new DateTime(2025, 8, 30, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2688), "Zapatillas Deportivas Urbanas", 79.99m, 75 },
                    { new Guid("b94dec15-7b74-4c65-9004-1434a3137841"), "Bolso de cuero genuino con múltiples compartimentos.", new DateTime(2025, 10, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2760), new DateTime(2025, 7, 16, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2758), "Bolso de Cuero Grande", 129.99m, 20 },
                    { new Guid("e62a79a3-9500-41ad-80c9-d2bffb25e08d"), "Taza de cerámica de alta calidad con diseño único.", new DateTime(2025, 10, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2818), new DateTime(2025, 10, 7, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2816), "Taza de Cerámica Decorada", 8.99m, 200 },
                    { new Guid("fd5e3497-7613-4795-b6c2-ac126cc423c1"), "Camiseta de manga corta, 100% algodón suave.", new DateTime(2025, 10, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2675), new DateTime(2025, 9, 14, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(2615), "Camiseta Básica Algodón", 19.99m, 100 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "256bce89-bbcf-47e4-9477-7a66547d8ba7", "889c0e2b-ae82-4bcb-9fa3-25d3168f4c94" },
                    { "95097de8-75af-40b5-b234-a8c9aeaf7fe0", "c99cca50-f8d9-411b-ae3d-4a72729c073f" },
                    { "4e731712-6fde-497b-9e70-aabecaccd030", "fd2c6f23-c997-4bd9-8b4c-5492a5501323" }
                });

            migrationBuilder.InsertData(
                table: "Direcciones",
                columns: new[] { "IdDireccion", "Ciudad", "CodigoPostal", "Domicilio", "IdUsuario", "Pais", "Provincia", "principal" },
                values: new object[,]
                {
                    { new Guid("1d1132db-e8a1-4e6d-9008-6ca9e4ebf766"), "Barcelona", 8001, "Calle de la Piruleta 15", "c99cca50-f8d9-411b-ae3d-4a72729c073f", "España", "Barcelona", false },
                    { new Guid("92133601-31ab-4f47-86f9-483e11b457ca"), "Madrid", 28080, "Avenida Siempreviva 742", "c99cca50-f8d9-411b-ae3d-4a72729c073f", "España", "Madrid", true }
                });

            migrationBuilder.InsertData(
                table: "ProductosCategorias",
                columns: new[] { "IdProductoCategoria", "IdCategoria", "IdProducto" },
                values: new object[,]
                {
                    { new Guid("10094cfd-54e3-4b12-9726-160de42865a9"), new Guid("7432c6e6-5071-469d-950f-aaa1dd5144f4"), new Guid("5b83a272-091a-49a8-9410-fe0df1050c7e") },
                    { new Guid("3fe0505e-a6aa-4337-b9b3-eb37fd91d0d8"), new Guid("53fb44b3-7dfa-4c52-9305-6274c181d861"), new Guid("e62a79a3-9500-41ad-80c9-d2bffb25e08d") },
                    { new Guid("45c63ac5-30fb-4453-818f-c7bd89d90284"), new Guid("7432c6e6-5071-469d-950f-aaa1dd5144f4"), new Guid("1db3a7a5-9204-4964-8254-f4869406c51d") },
                    { new Guid("496bcc87-5fa1-4537-bbb4-f2394100c3e9"), new Guid("0eb1115e-75ee-44ea-b5de-15bbe78da54a"), new Guid("fd5e3497-7613-4795-b6c2-ac126cc423c1") },
                    { new Guid("67310719-7d2f-46b4-abde-a6b0e870603f"), new Guid("0eb1115e-75ee-44ea-b5de-15bbe78da54a"), new Guid("824776e3-0cc8-4d51-8e15-22c0cc608e4a") },
                    { new Guid("6c554b09-0bfe-4bce-8988-d8bb20cdc550"), new Guid("0d5b18c3-d126-4850-b5fb-4b1e93cb2dd5"), new Guid("0a0200e4-c1d9-4e7c-a268-9cf3a1b1797a") },
                    { new Guid("72fe28b7-36d2-4de8-9243-57bde3d9f6d6"), new Guid("8ddf324f-e2e6-45b1-91e3-e9a7fbb6f868"), new Guid("5b83a272-091a-49a8-9410-fe0df1050c7e") },
                    { new Guid("7b5eee2b-bb62-4328-a04b-0781edfc0061"), new Guid("0d45e702-9506-4edd-80ad-3cc2fc1f3854"), new Guid("b94dec15-7b74-4c65-9004-1434a3137841") },
                    { new Guid("7ea09b2a-81b3-4b01-9dea-1bcbd03686d7"), new Guid("8ddf324f-e2e6-45b1-91e3-e9a7fbb6f868"), new Guid("1db3a7a5-9204-4964-8254-f4869406c51d") },
                    { new Guid("88f7ecd2-1ea8-496a-92dd-8ca82bd3c8d5"), new Guid("1f3f91c0-2666-4e5a-81f0-e6969f1f2707"), new Guid("a5ac44e6-d2ed-4bad-af28-cf9b5a4c34fe") },
                    { new Guid("cb7c8fa5-d4e9-4c72-b066-e14be7751bf8"), new Guid("554cf31c-afce-4a38-87d9-309bb8b32873"), new Guid("a1c8c1c4-b461-41da-8162-5cca867f7f6c") },
                    { new Guid("ce060921-62fc-48a7-8ed8-c314f44879be"), new Guid("1f4c2afd-63ad-479b-affd-f4a9e4ca6dca"), new Guid("b94dec15-7b74-4c65-9004-1434a3137841") },
                    { new Guid("e8f3d6b1-37b7-4eff-bda7-3f1f47073759"), new Guid("1a0781b7-629f-462e-8487-c410b1391f5a"), new Guid("a5ac44e6-d2ed-4bad-af28-cf9b5a4c34fe") },
                    { new Guid("f0a75729-55ca-49bd-b860-12e7ad66ce18"), new Guid("1f4c2afd-63ad-479b-affd-f4a9e4ca6dca"), new Guid("a253f3df-8fd8-45c0-b265-32b5f0986a81") },
                    { new Guid("f8eb6619-2a7b-4fa3-9865-af094616b60b"), new Guid("1f4c2afd-63ad-479b-affd-f4a9e4ca6dca"), new Guid("0a0200e4-c1d9-4e7c-a268-9cf3a1b1797a") }
                });

            migrationBuilder.InsertData(
                table: "Pedidos",
                columns: new[] { "IdPedido", "Estado", "FechaCreacion", "IdDireccion", "IdUsuario", "Numero", "Total" },
                values: new object[,]
                {
                    { new Guid("0aca61f9-87f7-4101-9385-b94fd22c8504"), "Pendiente", new DateTime(2025, 10, 13, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(5435), new Guid("92133601-31ab-4f47-86f9-483e11b457ca"), "c99cca50-f8d9-411b-ae3d-4a72729c073f", 1, 45.99m },
                    { new Guid("54169c66-583f-4a82-b2ac-6d36c5923a10"), "Enviado", new DateTime(2025, 10, 9, 12, 39, 12, 231, DateTimeKind.Local).AddTicks(5459), new Guid("92133601-31ab-4f47-86f9-483e11b457ca"), "c99cca50-f8d9-411b-ae3d-4a72729c073f", 2, 89.50m }
                });

            migrationBuilder.InsertData(
                table: "DetallesPedidos",
                columns: new[] { "IdDetalle", "Cantidad", "IdPedido", "IdProducto", "PrecioUnitario", "Subtotal" },
                values: new object[,]
                {
                    { new Guid("198299b6-6ac7-4e5b-859f-40ed6480d51e"), 1, new Guid("54169c66-583f-4a82-b2ac-6d36c5923a10"), new Guid("824776e3-0cc8-4d51-8e15-22c0cc608e4a"), 49.99m, 49.99m },
                    { new Guid("28d268f5-5d18-4aa3-a611-b525e5138c09"), 2, new Guid("0aca61f9-87f7-4101-9385-b94fd22c8504"), new Guid("fd5e3497-7613-4795-b6c2-ac126cc423c1"), 19.99m, 39.98m },
                    { new Guid("755d9d73-df0e-4d0a-ad63-0374f75dac03"), 1, new Guid("0aca61f9-87f7-4101-9385-b94fd22c8504"), new Guid("a1c8c1c4-b461-41da-8162-5cca867f7f6c"), 12.50m, 12.50m },
                    { new Guid("87bdf36e-55af-4312-b47b-025f6d646134"), 1, new Guid("54169c66-583f-4a82-b2ac-6d36c5923a10"), new Guid("5b83a272-091a-49a8-9410-fe0df1050c7e"), 69.99m, 69.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsCarrito_CarritoIdCarrito",
                table: "ItemsCarrito",
                column: "CarritoIdCarrito");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsCarrito_Carritos_CarritoIdCarrito",
                table: "ItemsCarrito",
                column: "CarritoIdCarrito",
                principalTable: "Carritos",
                principalColumn: "IdCarrito");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsCarrito_Carritos_CarritoIdCarrito",
                table: "ItemsCarrito");

            migrationBuilder.DropIndex(
                name: "IX_ItemsCarrito_CarritoIdCarrito",
                table: "ItemsCarrito");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "256bce89-bbcf-47e4-9477-7a66547d8ba7", "889c0e2b-ae82-4bcb-9fa3-25d3168f4c94" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95097de8-75af-40b5-b234-a8c9aeaf7fe0", "c99cca50-f8d9-411b-ae3d-4a72729c073f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4e731712-6fde-497b-9e70-aabecaccd030", "fd2c6f23-c997-4bd9-8b4c-5492a5501323" });

            migrationBuilder.DeleteData(
                table: "DetallesPedidos",
                keyColumn: "IdDetalle",
                keyValue: new Guid("198299b6-6ac7-4e5b-859f-40ed6480d51e"));

            migrationBuilder.DeleteData(
                table: "DetallesPedidos",
                keyColumn: "IdDetalle",
                keyValue: new Guid("28d268f5-5d18-4aa3-a611-b525e5138c09"));

            migrationBuilder.DeleteData(
                table: "DetallesPedidos",
                keyColumn: "IdDetalle",
                keyValue: new Guid("755d9d73-df0e-4d0a-ad63-0374f75dac03"));

            migrationBuilder.DeleteData(
                table: "DetallesPedidos",
                keyColumn: "IdDetalle",
                keyValue: new Guid("87bdf36e-55af-4312-b47b-025f6d646134"));

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "IdDireccion",
                keyValue: new Guid("1d1132db-e8a1-4e6d-9008-6ca9e4ebf766"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("10094cfd-54e3-4b12-9726-160de42865a9"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("3fe0505e-a6aa-4337-b9b3-eb37fd91d0d8"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("45c63ac5-30fb-4453-818f-c7bd89d90284"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("496bcc87-5fa1-4537-bbb4-f2394100c3e9"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("67310719-7d2f-46b4-abde-a6b0e870603f"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("6c554b09-0bfe-4bce-8988-d8bb20cdc550"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("72fe28b7-36d2-4de8-9243-57bde3d9f6d6"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("7b5eee2b-bb62-4328-a04b-0781edfc0061"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("7ea09b2a-81b3-4b01-9dea-1bcbd03686d7"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("88f7ecd2-1ea8-496a-92dd-8ca82bd3c8d5"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("cb7c8fa5-d4e9-4c72-b066-e14be7751bf8"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("ce060921-62fc-48a7-8ed8-c314f44879be"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("e8f3d6b1-37b7-4eff-bda7-3f1f47073759"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("f0a75729-55ca-49bd-b860-12e7ad66ce18"));

            migrationBuilder.DeleteData(
                table: "ProductosCategorias",
                keyColumn: "IdProductoCategoria",
                keyValue: new Guid("f8eb6619-2a7b-4fa3-9865-af094616b60b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "256bce89-bbcf-47e4-9477-7a66547d8ba7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e731712-6fde-497b-9e70-aabecaccd030");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95097de8-75af-40b5-b234-a8c9aeaf7fe0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "889c0e2b-ae82-4bcb-9fa3-25d3168f4c94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd2c6f23-c997-4bd9-8b4c-5492a5501323");

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("0d45e702-9506-4edd-80ad-3cc2fc1f3854"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("0d5b18c3-d126-4850-b5fb-4b1e93cb2dd5"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("0eb1115e-75ee-44ea-b5de-15bbe78da54a"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("1a0781b7-629f-462e-8487-c410b1391f5a"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("1f3f91c0-2666-4e5a-81f0-e6969f1f2707"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("1f4c2afd-63ad-479b-affd-f4a9e4ca6dca"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("53fb44b3-7dfa-4c52-9305-6274c181d861"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("554cf31c-afce-4a38-87d9-309bb8b32873"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("7432c6e6-5071-469d-950f-aaa1dd5144f4"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: new Guid("8ddf324f-e2e6-45b1-91e3-e9a7fbb6f868"));

            migrationBuilder.DeleteData(
                table: "Pedidos",
                keyColumn: "IdPedido",
                keyValue: new Guid("0aca61f9-87f7-4101-9385-b94fd22c8504"));

            migrationBuilder.DeleteData(
                table: "Pedidos",
                keyColumn: "IdPedido",
                keyValue: new Guid("54169c66-583f-4a82-b2ac-6d36c5923a10"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("0a0200e4-c1d9-4e7c-a268-9cf3a1b1797a"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("1db3a7a5-9204-4964-8254-f4869406c51d"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("5b83a272-091a-49a8-9410-fe0df1050c7e"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("824776e3-0cc8-4d51-8e15-22c0cc608e4a"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("a1c8c1c4-b461-41da-8162-5cca867f7f6c"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("a253f3df-8fd8-45c0-b265-32b5f0986a81"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("a5ac44e6-d2ed-4bad-af28-cf9b5a4c34fe"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("b94dec15-7b74-4c65-9004-1434a3137841"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("e62a79a3-9500-41ad-80c9-d2bffb25e08d"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("fd5e3497-7613-4795-b6c2-ac126cc423c1"));

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "IdDireccion",
                keyValue: new Guid("92133601-31ab-4f47-86f9-483e11b457ca"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c99cca50-f8d9-411b-ae3d-4a72729c073f");

            migrationBuilder.DropColumn(
                name: "CarritoIdCarrito",
                table: "ItemsCarrito");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4eb7fdef-aa3c-473e-94b0-1521fca6475e", null, "Cliente", "CLIENTE" },
                    { "71061cec-029c-4dec-b1f0-24828b683206", null, "Admin", "ADMIN" },
                    { "e256a823-d66c-457c-850e-4c66ea6f9173", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "51e5f7db-a9cc-4886-95e5-b9a5d5bed5e5", 0, "09eb7659-1c69-4a82-ac6a-7c6fe6a16c86", "lucia.sanchiz@nexusshop.com", true, false, null, "LUCIA.SANCHIZ@NEXUSSHOP.COM", "LUCIA.SANCHIZ@NEXUSSHOP.COM", "AQAAAAIAAYagAAAAEDJq2SZ2kl84o+rEf6KJWDaZFwc/+61zCRDDnmfufPJ+YeTMyVQU2UL5ONcrUVTJSQ==", "685214739", false, "7b36c552-9d84-420b-91c8-35dc39e63e1b", false, "lucia.sanchiz@nexusshop.com" },
                    { "7f6ba682-5e9f-4f59-8805-1f5372d5f35b", 0, "d7c69dc8-0145-475b-b74e-b58dc572355d", "paco.montoro@gmail.com", true, false, null, "PACO.MONTORO@GMAIL.COM", "PACO.MONTORO@GMAIL.COM", "AQAAAAIAAYagAAAAEAdjZZ7LmXCue1xMeaSuAhV1x1uaYiddNlCI0hMCEr+5TpunPoJXVzABo1daDq3uPw==", "632514785", false, "a5a2b3c1-2ffc-434a-b54a-85a11587f185", false, "paco.montoro@gmail.com" },
                    { "d8e55bc7-cccf-4295-8193-44708d9c8710", 0, "40ace187-0738-4a43-bc71-71eb8f5f98c0", "admin@nexusshop.com", true, false, null, "ADMIN@NEXUSSHOP.COM", "ADMIN@NEXUSSHOP.COM", "AQAAAAIAAYagAAAAEDMwTh8JCsdVd530P7JTFUdqrPBtKYBbsVBKjoEQVyYfyMzOH6+rbcffynJDB1sxWA==", "653124875", false, "2c68f4c8-687e-48b1-ad7c-327eb97c7c4f", false, "admin@nexusshop.com" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "IdCategoria", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0199fb45-4f90-41f9-88f5-823cbecbbfc5"), "Deportes" },
                    { new Guid("1e151a41-ab08-4f66-9c64-c3e95c97af47"), "Tecnología" },
                    { new Guid("24bf372e-8936-4fbf-8d21-81b91e7c9a25"), "Ropa" },
                    { new Guid("4ee9ea41-0b2a-4a42-9637-b143034a590c"), "Accesorios" },
                    { new Guid("82252331-cf7f-4544-8161-d3c33cae4121"), "Belleza" },
                    { new Guid("ba62943f-1480-4bdd-b590-f824b70fc1fe"), "Libros" },
                    { new Guid("bf395ed3-c1e5-4cbc-93f5-d73a880d5774"), "Hogar" },
                    { new Guid("e7e3f7ca-5d40-4d23-8ffa-44a7aea070b8"), "Electrónica" },
                    { new Guid("e98f528d-99cc-4b55-b1d6-eda10ecfc879"), "Joyería" },
                    { new Guid("fd312981-e795-403d-a31d-5a32077c0232"), "Calzado" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Descripcion", "FechaActualizacion", "FechaCreacion", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { new Guid("66b287c6-acd0-47e4-b0af-045cde2d6433"), "Taza de cerámica de alta calidad con diseño único.", new DateTime(2025, 5, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5201), new DateTime(2025, 5, 14, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5199), "Taza de Cerámica Decorada", 8.99m, 200 },
                    { new Guid("71bb098c-ee88-4b42-87a6-28058b5687c7"), "Una emocionante novela de fantasía y aventuras.", new DateTime(2025, 5, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5188), new DateTime(2025, 5, 6, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5185), "Libro 'Aventuras Épicas'", 12.50m, 150 },
                    { new Guid("723863c8-1a7e-444b-92c5-a5933f9a7d87"), "Reloj elegante con correa de cuero y movimiento de cuarzo.", new DateTime(2025, 5, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5232), new DateTime(2025, 4, 1, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5230), "Reloj de Pulsera Clásico", 99.99m, 30 },
                    { new Guid("90fa0563-17c1-4779-9fd9-ce313d115060"), "Gafas de sol con lentes polarizadas para una visión clara.", new DateTime(2025, 5, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5149), new DateTime(2025, 5, 1, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5148), "Gafas de Sol Polarizadas", 59.99m, 60 },
                    { new Guid("97bc96e2-dd06-40a0-8c98-c43e18d774c0"), "Auriculares con conexión Bluetooth y sonido de alta fidelidad.", new DateTime(2025, 5, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5238), new DateTime(2025, 4, 26, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5237), "Auriculares Inalámbricos Bluetooth", 69.99m, 80 },
                    { new Guid("a7987e74-9e49-410b-a709-f472f93a298c"), "Bolso de cuero genuino con múltiples compartimentos.", new DateTime(2025, 5, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5144), new DateTime(2025, 2, 20, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5142), "Bolso de Cuero Grande", 129.99m, 20 },
                    { new Guid("b8450b78-cd14-4e65-97ac-3649a55fd9a0"), "Funda resistente para proteger tu teléfono de golpes y arañazos.", new DateTime(2025, 5, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5226), new DateTime(2025, 4, 16, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5204), "Funda Protectora para Smartphone", 24.99m, 120 },
                    { new Guid("c464ef7d-1568-4ac8-8452-2accb5e78be3"), "Pantalón vaquero clásico de corte recto.", new DateTime(2025, 5, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5052), new DateTime(2025, 3, 22, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5050), "Pantalón Vaquero Recto", 49.99m, 50 },
                    { new Guid("cbbe008e-9d5d-4cf4-a4fa-2d2c910c9515"), "Zapatillas cómodas y con estilo para el día a día.", new DateTime(2025, 5, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5129), new DateTime(2025, 4, 6, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5056), "Zapatillas Deportivas Urbanas", 79.99m, 75 },
                    { new Guid("e0009b89-c414-4715-95ad-095fa75dc331"), "Camiseta de manga corta, 100% algodón suave.", new DateTime(2025, 5, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(5043), new DateTime(2025, 4, 21, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(4990), "Camiseta Básica Algodón", 19.99m, 100 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e256a823-d66c-457c-850e-4c66ea6f9173", "51e5f7db-a9cc-4886-95e5-b9a5d5bed5e5" },
                    { "4eb7fdef-aa3c-473e-94b0-1521fca6475e", "7f6ba682-5e9f-4f59-8805-1f5372d5f35b" },
                    { "71061cec-029c-4dec-b1f0-24828b683206", "d8e55bc7-cccf-4295-8193-44708d9c8710" }
                });

            migrationBuilder.InsertData(
                table: "Direcciones",
                columns: new[] { "IdDireccion", "Ciudad", "CodigoPostal", "Domicilio", "IdUsuario", "Pais", "Provincia", "principal" },
                values: new object[,]
                {
                    { new Guid("ec83090e-331c-4a3e-ac73-48e049b8665a"), "Barcelona", 8001, "Calle de la Piruleta 15", "7f6ba682-5e9f-4f59-8805-1f5372d5f35b", "España", "Barcelona", false },
                    { new Guid("f1f7ea57-94ed-4c28-b16f-80e2e2bb56b9"), "Madrid", 28080, "Avenida Siempreviva 742", "7f6ba682-5e9f-4f59-8805-1f5372d5f35b", "España", "Madrid", true }
                });

            migrationBuilder.InsertData(
                table: "ProductosCategorias",
                columns: new[] { "IdProductoCategoria", "IdCategoria", "IdProducto" },
                values: new object[,]
                {
                    { new Guid("184c4879-5b84-47b4-af27-2c8260f15fd5"), new Guid("24bf372e-8936-4fbf-8d21-81b91e7c9a25"), new Guid("c464ef7d-1568-4ac8-8452-2accb5e78be3") },
                    { new Guid("253cc766-74db-4933-8519-0754937e88e9"), new Guid("e98f528d-99cc-4b55-b1d6-eda10ecfc879"), new Guid("723863c8-1a7e-444b-92c5-a5933f9a7d87") },
                    { new Guid("2d2ffcc2-9dd0-4878-abbe-00e9de78deaa"), new Guid("fd312981-e795-403d-a31d-5a32077c0232"), new Guid("cbbe008e-9d5d-4cf4-a4fa-2d2c910c9515") },
                    { new Guid("516af201-534f-43ed-9b28-6a326a303f10"), new Guid("bf395ed3-c1e5-4cbc-93f5-d73a880d5774"), new Guid("66b287c6-acd0-47e4-b0af-045cde2d6433") },
                    { new Guid("5e077d2e-6a33-4d92-8980-9a8e2e4ff090"), new Guid("4ee9ea41-0b2a-4a42-9637-b143034a590c"), new Guid("90fa0563-17c1-4779-9fd9-ce313d115060") },
                    { new Guid("5e5db5a4-2491-41dd-9da9-464e7b5c5f0c"), new Guid("4ee9ea41-0b2a-4a42-9637-b143034a590c"), new Guid("723863c8-1a7e-444b-92c5-a5933f9a7d87") },
                    { new Guid("6b71d369-9edd-4012-b445-9693b884d7a6"), new Guid("4ee9ea41-0b2a-4a42-9637-b143034a590c"), new Guid("a7987e74-9e49-410b-a709-f472f93a298c") },
                    { new Guid("7f77872d-7275-4edc-8a4e-a879d66e0c73"), new Guid("e7e3f7ca-5d40-4d23-8ffa-44a7aea070b8"), new Guid("b8450b78-cd14-4e65-97ac-3649a55fd9a0") },
                    { new Guid("8325752a-6bd9-4e82-9c16-e59e97c3de6e"), new Guid("1e151a41-ab08-4f66-9c64-c3e95c97af47"), new Guid("b8450b78-cd14-4e65-97ac-3649a55fd9a0") },
                    { new Guid("9974718d-39c2-4f04-9d9e-00019ea6b87f"), new Guid("82252331-cf7f-4544-8161-d3c33cae4121"), new Guid("a7987e74-9e49-410b-a709-f472f93a298c") },
                    { new Guid("c181869f-08a4-4ce2-aa45-9f599536568d"), new Guid("e7e3f7ca-5d40-4d23-8ffa-44a7aea070b8"), new Guid("97bc96e2-dd06-40a0-8c98-c43e18d774c0") },
                    { new Guid("c4487414-5bc0-4f23-8ce3-e7794f1de576"), new Guid("1e151a41-ab08-4f66-9c64-c3e95c97af47"), new Guid("97bc96e2-dd06-40a0-8c98-c43e18d774c0") },
                    { new Guid("ce27ed17-5d11-411e-b0a1-7706adf478ae"), new Guid("24bf372e-8936-4fbf-8d21-81b91e7c9a25"), new Guid("e0009b89-c414-4715-95ad-095fa75dc331") },
                    { new Guid("e5d0b040-f7d0-42c8-8330-42f6fdff3458"), new Guid("0199fb45-4f90-41f9-88f5-823cbecbbfc5"), new Guid("cbbe008e-9d5d-4cf4-a4fa-2d2c910c9515") },
                    { new Guid("eb86f009-daca-4b04-aa88-828ed2c2615b"), new Guid("ba62943f-1480-4bdd-b590-f824b70fc1fe"), new Guid("71bb098c-ee88-4b42-87a6-28058b5687c7") }
                });

            migrationBuilder.InsertData(
                table: "Pedidos",
                columns: new[] { "IdPedido", "Estado", "FechaCreacion", "IdDireccion", "IdUsuario", "Numero", "Total" },
                values: new object[,]
                {
                    { new Guid("0ed5d9ee-359a-4d79-9789-f796996554c0"), "Enviado", new DateTime(2025, 5, 16, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(8446), new Guid("f1f7ea57-94ed-4c28-b16f-80e2e2bb56b9"), "7f6ba682-5e9f-4f59-8805-1f5372d5f35b", 2, 89.50m },
                    { new Guid("25054ab4-7ad3-4c5d-a3d7-d4c8105cc4e3"), "Pendiente", new DateTime(2025, 5, 20, 10, 40, 34, 615, DateTimeKind.Local).AddTicks(8424), new Guid("f1f7ea57-94ed-4c28-b16f-80e2e2bb56b9"), "7f6ba682-5e9f-4f59-8805-1f5372d5f35b", 1, 45.99m }
                });

            migrationBuilder.InsertData(
                table: "DetallesPedidos",
                columns: new[] { "IdDetalle", "Cantidad", "IdPedido", "IdProducto", "PrecioUnitario", "Subtotal" },
                values: new object[,]
                {
                    { new Guid("514677cd-56e8-4d03-ad5f-3513bcee8d0f"), 1, new Guid("0ed5d9ee-359a-4d79-9789-f796996554c0"), new Guid("c464ef7d-1568-4ac8-8452-2accb5e78be3"), 49.99m, 49.99m },
                    { new Guid("b55bfb46-5cb5-4df2-b54d-67ee1ab2dc7d"), 1, new Guid("25054ab4-7ad3-4c5d-a3d7-d4c8105cc4e3"), new Guid("71bb098c-ee88-4b42-87a6-28058b5687c7"), 12.50m, 12.50m },
                    { new Guid("fdac9a7a-f6f2-46f4-8bc5-211bd6762cb0"), 2, new Guid("25054ab4-7ad3-4c5d-a3d7-d4c8105cc4e3"), new Guid("e0009b89-c414-4715-95ad-095fa75dc331"), 19.99m, 39.98m },
                    { new Guid("fdfb1d9e-cc61-4377-b322-f8f15e26e4da"), 1, new Guid("0ed5d9ee-359a-4d79-9789-f796996554c0"), new Guid("97bc96e2-dd06-40a0-8c98-c43e18d774c0"), 69.99m, 69.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsCarrito_IdCarrito",
                table: "ItemsCarrito",
                column: "IdCarrito");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsCarrito_Carritos_IdCarrito",
                table: "ItemsCarrito",
                column: "IdCarrito",
                principalTable: "Carritos",
                principalColumn: "IdCarrito",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
