﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mix.Cms.Lib.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mix_attribute_set",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 250, nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    FormTemplate = table.Column<string>(maxLength: 250, nullable: true),
                    EdmTemplate = table.Column<string>(maxLength: 250, nullable: true),
                    EdmSubject = table.Column<string>(maxLength: 250, nullable: true),
                    EdmFrom = table.Column<string>(maxLength: 250, nullable: true),
                    EdmAutoSend = table.Column<bool>(nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_attribute_set", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mix_attribute_set_value",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    AttributeFieldId = table.Column<int>(nullable: false),
                    AttributeFieldName = table.Column<string>(maxLength: 50, nullable: false),
                    AttributeSetName = table.Column<string>(maxLength: 250, nullable: true),
                    Regex = table.Column<string>(maxLength: 250, nullable: true),
                    DataType = table.Column<int>(nullable: false),
                    BooleanValue = table.Column<bool>(nullable: true),
                    DataId = table.Column<string>(maxLength: 50, nullable: false),
                    DateTimeValue = table.Column<DateTime>(type: "datetime", nullable: true),
                    DoubleValue = table.Column<double>(nullable: true),
                    IntegerValue = table.Column<int>(nullable: true),
                    StringValue = table.Column<string>(maxLength: 4000, nullable: true),
                    EncryptValue = table.Column<string>(maxLength: 4000, nullable: true),
                    EncryptKey = table.Column<string>(maxLength: 50, nullable: true),
                    EncryptType = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_attribute_set_value", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mix_cache",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Value = table.Column<string>(maxLength: 4000, nullable: false),
                    ExpiredDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_cache", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mix_cms_user",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    Avatar = table.Column<string>(maxLength: 250, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Username = table.Column<string>(maxLength: 250, nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_cms_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mix_culture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Alias = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    FullName = table.Column<string>(maxLength: 150, nullable: true),
                    Icon = table.Column<string>(maxLength: 50, nullable: true),
                    LCID = table.Column<string>(maxLength: 50, nullable: true),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_culture", x => x.Id);
                    table.UniqueConstraint("AK_mix_culture_Specificulture", x => x.Specificulture);
                });

            migrationBuilder.CreateTable(
                name: "mix_media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Extension = table.Column<string>(maxLength: 50, nullable: false),
                    FileFolder = table.Column<string>(maxLength: 250, nullable: false),
                    FileName = table.Column<string>(maxLength: 250, nullable: false),
                    FileProperties = table.Column<string>(maxLength: 4000, nullable: true),
                    FileSize = table.Column<long>(nullable: false),
                    FileType = table.Column<string>(maxLength: 50, nullable: false),
                    Title = table.Column<string>(maxLength: 4000, nullable: true),
                    Tags = table.Column<string>(maxLength: 400, nullable: true),
                    Source = table.Column<string>(maxLength: 250, nullable: true),
                    TargetUrl = table.Column<string>(maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_media", x => new { x.Id, x.Specificulture });
                });

            migrationBuilder.CreateTable(
                name: "mix_portal_page",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Icon = table.Column<string>(maxLength: 50, nullable: true),
                    TextKeyword = table.Column<string>(maxLength: 250, nullable: true),
                    Url = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 450, nullable: true),
                    TextDefault = table.Column<string>(maxLength: 250, nullable: true),
                    Level = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_portal_page", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mix_related_attribute_data",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    DataId = table.Column<string>(maxLength: 50, nullable: false),
                    ParentId = table.Column<string>(maxLength: 50, nullable: false),
                    ParentType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AttributeSetId = table.Column<int>(nullable: false),
                    AttributeSetName = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 450, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_related_attribute_data_1", x => new { x.Id, x.Specificulture });
                });

            migrationBuilder.CreateTable(
                name: "mix_related_data",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    DataId = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    ParentId = table.Column<string>(maxLength: 50, nullable: false),
                    ParentType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AttributeSetId = table.Column<int>(nullable: false),
                    AttributeSetName = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 450, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_related_data", x => new { x.Id, x.Specificulture });
                });

            migrationBuilder.CreateTable(
                name: "mix_theme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Thumbnail = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    Title = table.Column<string>(maxLength: 250, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    PreviewUrl = table.Column<string>(maxLength: 450, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_theme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mix_attribute_field",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AttributeSetId = table.Column<int>(nullable: false),
                    AttributeSetName = table.Column<string>(maxLength: 250, nullable: true),
                    Regex = table.Column<string>(maxLength: 250, nullable: true),
                    Title = table.Column<string>(maxLength: 250, nullable: true),
                    DataType = table.Column<int>(nullable: false),
                    DefaultValue = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Options = table.Column<string>(type: "text", nullable: true),
                    IsRequire = table.Column<bool>(nullable: false),
                    IsEncrypt = table.Column<bool>(nullable: false),
                    IsMultiple = table.Column<bool>(nullable: false),
                    IsSelect = table.Column<bool>(nullable: false),
                    IsUnique = table.Column<bool>(nullable: false),
                    ReferenceId = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_attribute_field", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mix_attribute_field_mix_attribute_set",
                        column: x => x.AttributeSetId,
                        principalTable: "mix_attribute_set",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mix_attribute_field_mix_attribute_set1",
                        column: x => x.ReferenceId,
                        principalTable: "mix_attribute_set",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_attribute_set_data",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    AttributeSetId = table.Column<int>(nullable: false),
                    AttributeSetName = table.Column<string>(maxLength: 250, nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_attribute_set_data", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_mix_attribute_set_data_mix_attribute_set",
                        column: x => x.AttributeSetId,
                        principalTable: "mix_attribute_set",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_attribute_set_reference",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    ParentType = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 450, nullable: true),
                    Image = table.Column<string>(maxLength: 450, nullable: true),
                    AttributeSetId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_attribute_set_reference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mix_attribute_set_reference_mix_attribute_set",
                        column: x => x.AttributeSetId,
                        principalTable: "mix_attribute_set",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_related_attribute_set",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    SetId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    ParentType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 450, nullable: true),
                    Image = table.Column<string>(maxLength: 450, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_related_attribute_set", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_mix_related_attribute_set_mix_attribute_set",
                        column: x => x.Id,
                        principalTable: "mix_attribute_set",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    Keyword = table.Column<string>(maxLength: 50, nullable: false),
                    Category = table.Column<string>(maxLength: 250, nullable: true),
                    DataType = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Value = table.Column<string>(maxLength: 4000, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_configuration_1", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Configuration_Mix_Culture",
                        column: x => x.Specificulture,
                        principalTable: "mix_culture",
                        principalColumn: "Specificulture",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mix_language",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    Keyword = table.Column<string>(maxLength: 50, nullable: false),
                    Category = table.Column<string>(maxLength: 250, nullable: true),
                    DataType = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Value = table.Column<string>(maxLength: 4000, nullable: true),
                    DefaultValue = table.Column<string>(maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_language_1", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Language_Mix_Culture",
                        column: x => x.Specificulture,
                        principalTable: "mix_culture",
                        principalColumn: "Specificulture",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mix_module",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Fields = table.Column<string>(maxLength: 4000, nullable: true),
                    Thumbnail = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Template = table.Column<string>(maxLength: 250, nullable: true),
                    FormTemplate = table.Column<string>(maxLength: 250, nullable: true),
                    EdmTemplate = table.Column<string>(maxLength: 250, nullable: true),
                    Title = table.Column<string>(maxLength: 250, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    PageSize = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_module", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Module_Mix_Culture",
                        column: x => x.Specificulture,
                        principalTable: "mix_culture",
                        principalColumn: "Specificulture",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mix_page",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    CssClass = table.Column<string>(maxLength: 250, nullable: true),
                    Excerpt = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(maxLength: 50, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    Layout = table.Column<string>(maxLength: 50, nullable: true),
                    Level = table.Column<int>(nullable: true),
                    SeoDescription = table.Column<string>(type: "text", nullable: true),
                    SeoKeywords = table.Column<string>(type: "text", nullable: true),
                    SeoName = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    StaticUrl = table.Column<string>(maxLength: 250, nullable: true),
                    Tags = table.Column<string>(type: "text", nullable: true),
                    Template = table.Column<string>(maxLength: 250, nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Views = table.Column<int>(nullable: true),
                    PageSize = table.Column<int>(nullable: true),
                    ExtraFields = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_page", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Page_Mix_Culture",
                        column: x => x.Specificulture,
                        principalTable: "mix_culture",
                        principalColumn: "Specificulture",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    PublishedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Excerpt = table.Column<string>(type: "text", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    SeoDescription = table.Column<string>(type: "text", nullable: true),
                    SeoKeywords = table.Column<string>(type: "text", nullable: true),
                    SeoName = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(type: "text", nullable: true),
                    Source = table.Column<string>(maxLength: 250, nullable: true),
                    Tags = table.Column<string>(type: "text", nullable: true),
                    Template = table.Column<string>(maxLength: 250, nullable: true),
                    Thumbnail = table.Column<string>(maxLength: 250, nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Views = table.Column<int>(nullable: true),
                    ExtraFields = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_post", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Post_Mix_Culture",
                        column: x => x.Specificulture,
                        principalTable: "mix_culture",
                        principalColumn: "Specificulture",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_url_alias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    SourceId = table.Column<string>(maxLength: 250, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Alias = table.Column<string>(maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_url_alias", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Url_Alias_Mix_Culture",
                        column: x => x.Specificulture,
                        principalTable: "mix_culture",
                        principalColumn: "Specificulture",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mix_portal_page_navigation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PageId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_portal_page_navigation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mix_portal_page_navigation_mix_portal_page",
                        column: x => x.PageId,
                        principalTable: "mix_portal_page",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mix_portal_page_navigation_mix_portal_page1",
                        column: x => x.ParentId,
                        principalTable: "mix_portal_page",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_portal_page_role",
                columns: table => new
                {
                    PageId = table.Column<int>(nullable: false),
                    RoleId = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_portal_page_role", x => new { x.RoleId, x.PageId });
                    table.ForeignKey(
                        name: "FK_mix_portal_page_role_mix_portal_page",
                        column: x => x.PageId,
                        principalTable: "mix_portal_page",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mix_file",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StringContent = table.Column<string>(maxLength: 4000, nullable: false),
                    Extension = table.Column<string>(maxLength: 50, nullable: false),
                    FileFolder = table.Column<string>(maxLength: 250, nullable: false),
                    FileName = table.Column<string>(maxLength: 250, nullable: false),
                    FolderType = table.Column<string>(maxLength: 50, nullable: false),
                    ThemeId = table.Column<int>(nullable: true),
                    ThemeName = table.Column<string>(maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_file", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mix_file_mix_template",
                        column: x => x.ThemeId,
                        principalTable: "mix_theme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_template",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Extension = table.Column<string>(maxLength: 50, nullable: false),
                    FileFolder = table.Column<string>(maxLength: 250, nullable: false),
                    FileName = table.Column<string>(maxLength: 250, nullable: false),
                    FolderType = table.Column<string>(maxLength: 50, nullable: false),
                    MobileContent = table.Column<string>(type: "text", nullable: true),
                    Scripts = table.Column<string>(type: "text", nullable: true),
                    SpaContent = table.Column<string>(type: "text", nullable: true),
                    Styles = table.Column<string>(type: "text", nullable: true),
                    ThemeId = table.Column<int>(nullable: false),
                    ThemeName = table.Column<string>(maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_template", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mix_template_mix_theme",
                        column: x => x.ThemeId,
                        principalTable: "mix_theme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_page_module",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    PageId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    Position = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_page_module", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Menu_Module_Mix_Module1",
                        columns: x => new { x.ModuleId, x.Specificulture },
                        principalTable: "mix_module",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mix_Page_Module_Mix_Page",
                        columns: x => new { x.PageId, x.Specificulture },
                        principalTable: "mix_page",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_module_data",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    PageId = table.Column<int>(nullable: true),
                    PostId = table.Column<int>(nullable: true),
                    Fields = table.Column<string>(maxLength: 4000, nullable: false),
                    Value = table.Column<string>(maxLength: 4000, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_module_data", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Module_Data_Mix_Module",
                        columns: x => new { x.ModuleId, x.Specificulture },
                        principalTable: "mix_module",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mix_module_data_mix_page",
                        columns: x => new { x.PageId, x.Specificulture },
                        principalTable: "mix_page",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mix_module_data_mix_post",
                        columns: x => new { x.PostId, x.Specificulture },
                        principalTable: "mix_post",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_module_post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_module_post", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Module_Post_Mix_Module",
                        columns: x => new { x.ModuleId, x.Specificulture },
                        principalTable: "mix_module",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mix_Module_Post_Mix_Post",
                        columns: x => new { x.PostId, x.Specificulture },
                        principalTable: "mix_post",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_page_post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    PageId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_page_post", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Page_Post_Mix_Page",
                        columns: x => new { x.PageId, x.Specificulture },
                        principalTable: "mix_page",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mix_Page_Post_Mix_Post",
                        columns: x => new { x.PostId, x.Specificulture },
                        principalTable: "mix_post",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_post_media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    MediaId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    Position = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_post_media", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_mix_post_media_mix_media",
                        columns: x => new { x.MediaId, x.Specificulture },
                        principalTable: "mix_media",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mix_post_media_mix_post",
                        columns: x => new { x.PostId, x.Specificulture },
                        principalTable: "mix_post",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_post_module",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    Position = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_post_module", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_Mix_Post_Module_Mix_Module1",
                        columns: x => new { x.ModuleId, x.Specificulture },
                        principalTable: "mix_module",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mix_Post_Module_Mix_Post",
                        columns: x => new { x.PostId, x.Specificulture },
                        principalTable: "mix_post",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mix_related_post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Specificulture = table.Column<string>(maxLength: 10, nullable: false),
                    SourceId = table.Column<int>(nullable: false),
                    DestinationId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 450, nullable: true),
                    Image = table.Column<string>(maxLength: 450, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mix_related_post", x => new { x.Id, x.Specificulture });
                    table.ForeignKey(
                        name: "FK_mix_related_post_mix_post1",
                        columns: x => new { x.DestinationId, x.Specificulture },
                        principalTable: "mix_post",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mix_related_post_mix_post",
                        columns: x => new { x.SourceId, x.Specificulture },
                        principalTable: "mix_post",
                        principalColumns: new[] { "Id", "Specificulture" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mix_attribute_field_AttributeSetId",
                table: "mix_attribute_field",
                column: "AttributeSetId");

            migrationBuilder.CreateIndex(
                name: "IX_mix_attribute_field_ReferenceId",
                table: "mix_attribute_field",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_mix_attribute_set_data_AttributeSetId",
                table: "mix_attribute_set_data",
                column: "AttributeSetId");

            migrationBuilder.CreateIndex(
                name: "IX_mix_attribute_set_reference_AttributeSetId",
                table: "mix_attribute_set_reference",
                column: "AttributeSetId");

            migrationBuilder.CreateIndex(
                name: "IX_mix_attribute_set_value_DataId",
                table: "mix_attribute_set_value",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "Index_ExpiresAtTime",
                table: "mix_cache",
                column: "ExpiredDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_mix_configuration_Specificulture",
                table: "mix_configuration",
                column: "Specificulture");

            migrationBuilder.CreateIndex(
                name: "IX_Mix_Culture",
                table: "mix_culture",
                column: "Specificulture",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_mix_file_ThemeId",
                table: "mix_file",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_mix_language_Specificulture",
                table: "mix_language",
                column: "Specificulture");

            migrationBuilder.CreateIndex(
                name: "IX_mix_module_Specificulture",
                table: "mix_module",
                column: "Specificulture");

            migrationBuilder.CreateIndex(
                name: "IX_mix_module_data_ModuleId_Specificulture",
                table: "mix_module_data",
                columns: new[] { "ModuleId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_module_data_PageId_Specificulture",
                table: "mix_module_data",
                columns: new[] { "PageId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_module_data_PostId_Specificulture",
                table: "mix_module_data",
                columns: new[] { "PostId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_module_data_ModuleId_PageId_Specificulture",
                table: "mix_module_data",
                columns: new[] { "ModuleId", "PageId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_module_post_ModuleId_Specificulture",
                table: "mix_module_post",
                columns: new[] { "ModuleId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_module_post_PostId_Specificulture",
                table: "mix_module_post",
                columns: new[] { "PostId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_page_Specificulture",
                table: "mix_page",
                column: "Specificulture");

            migrationBuilder.CreateIndex(
                name: "IX_mix_page_module_ModuleId_Specificulture",
                table: "mix_page_module",
                columns: new[] { "ModuleId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_page_module_PageId_Specificulture",
                table: "mix_page_module",
                columns: new[] { "PageId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_page_post_PageId_Specificulture",
                table: "mix_page_post",
                columns: new[] { "PageId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_page_post_PostId_Specificulture",
                table: "mix_page_post",
                columns: new[] { "PostId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_portal_page_navigation_ParentId",
                table: "mix_portal_page_navigation",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_mix_portal_page_role_PageId",
                table: "mix_portal_page_role",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_mix_post_Specificulture",
                table: "mix_post",
                column: "Specificulture");

            migrationBuilder.CreateIndex(
                name: "IX_mix_post_media_MediaId_Specificulture",
                table: "mix_post_media",
                columns: new[] { "MediaId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_post_media_PostId_Specificulture",
                table: "mix_post_media",
                columns: new[] { "PostId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_post_module_ModuleId_Specificulture",
                table: "mix_post_module",
                columns: new[] { "ModuleId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_post_module_PostId_Specificulture",
                table: "mix_post_module",
                columns: new[] { "PostId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_related_post_DestinationId_Specificulture",
                table: "mix_related_post",
                columns: new[] { "DestinationId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_related_post_SourceId_Specificulture",
                table: "mix_related_post",
                columns: new[] { "SourceId", "Specificulture" });

            migrationBuilder.CreateIndex(
                name: "IX_mix_template_file_TemplateId",
                table: "mix_template",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_mix_url_alias_Specificulture",
                table: "mix_url_alias",
                column: "Specificulture");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mix_attribute_field");

            migrationBuilder.DropTable(
                name: "mix_attribute_set_data");

            migrationBuilder.DropTable(
                name: "mix_attribute_set_reference");

            migrationBuilder.DropTable(
                name: "mix_attribute_set_value");

            migrationBuilder.DropTable(
                name: "mix_cache");

            migrationBuilder.DropTable(
                name: "mix_cms_user");

            migrationBuilder.DropTable(
                name: "mix_configuration");

            migrationBuilder.DropTable(
                name: "mix_file");

            migrationBuilder.DropTable(
                name: "mix_language");

            migrationBuilder.DropTable(
                name: "mix_module_data");

            migrationBuilder.DropTable(
                name: "mix_module_post");

            migrationBuilder.DropTable(
                name: "mix_page_module");

            migrationBuilder.DropTable(
                name: "mix_page_post");

            migrationBuilder.DropTable(
                name: "mix_portal_page_navigation");

            migrationBuilder.DropTable(
                name: "mix_portal_page_role");

            migrationBuilder.DropTable(
                name: "mix_post_media");

            migrationBuilder.DropTable(
                name: "mix_post_module");

            migrationBuilder.DropTable(
                name: "mix_related_attribute_data");

            migrationBuilder.DropTable(
                name: "mix_related_attribute_set");

            migrationBuilder.DropTable(
                name: "mix_related_data");

            migrationBuilder.DropTable(
                name: "mix_related_post");

            migrationBuilder.DropTable(
                name: "mix_template");

            migrationBuilder.DropTable(
                name: "mix_url_alias");

            migrationBuilder.DropTable(
                name: "mix_page");

            migrationBuilder.DropTable(
                name: "mix_portal_page");

            migrationBuilder.DropTable(
                name: "mix_media");

            migrationBuilder.DropTable(
                name: "mix_module");

            migrationBuilder.DropTable(
                name: "mix_attribute_set");

            migrationBuilder.DropTable(
                name: "mix_post");

            migrationBuilder.DropTable(
                name: "mix_theme");

            migrationBuilder.DropTable(
                name: "mix_culture");
        }
    }
}
