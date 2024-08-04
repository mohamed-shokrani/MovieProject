import { proxyTexts } from "@serenity-is/corelib";

namespace MovieProject.Texts {

    export declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RoleName: string;
                export const RolePermissionId: string;
            }

            namespace Translation {
                export const CustomText: string;
                export const EntityPlural: string;
                export const Key: string;
                export const OverrideConfirmation: string;
                export const SaveChangesButton: string;
                export const SourceLanguage: string;
                export const SourceText: string;
                export const TargetLanguage: string;
                export const TargetText: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const RoleName: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace MovieDB {

            namespace Genre {
                export const GenreId: string;
                export const Name: string;
            }

            namespace Movie {
                export const Descrition: string;
                export const GenreList: string;
                export const Image: string;
                export const Kind: string;
                export const MovieId: string;
                export const Title: string;
            }

            namespace MovieCast {
                export const Character: string;
                export const MovieCastId: string;
                export const MovieId: string;
                export const MovieTitle: string;
                export const PersonFirstName: string;
                export const PersonId: string;
            }

            namespace MovieGenres {
                export const GenreId: string;
                export const GenreName: string;
                export const MovieGenreId: string;
                export const MovieId: string;
                export const MovieTitle: string;
            }

            namespace Person {
                export const BirthDate: string;
                export const BirthPlace: string;
                export const FirstName: string;
                export const Gender: string;
                export const Height: string;
                export const LastName: string;
                export const PersonId: string;
            }
        }

        namespace Northwind {

            namespace OrderDetails {
                export const DetailId: string;
                export const Discount: string;
                export const OrderCustomerId: string;
                export const OrderId: string;
                export const ProductId: string;
                export const ProductName: string;
                export const Quantity: string;
                export const UnitPrice: string;
            }

            namespace OrderDetailsExtended {
                export const Discount: string;
                export const ExtendedPrice: string;
                export const OrderId: string;
                export const ProductId: string;
                export const ProductName: string;
                export const Quantity: string;
                export const UnitPrice: string;
            }

            namespace OrderSubtotals {
                export const OrderId: string;
                export const Subtotal: string;
            }

            namespace Orders {
                export const CustomerCompanyName: string;
                export const CustomerId: string;
                export const EmployeeFullName: string;
                export const EmployeeId: string;
                export const Freight: string;
                export const OrderDate: string;
                export const OrderId: string;
                export const RequiredDate: string;
                export const ShipAddress: string;
                export const ShipCity: string;
                export const ShipCountry: string;
                export const ShipName: string;
                export const ShipPostalCode: string;
                export const ShipRegion: string;
                export const ShipVia: string;
                export const ShipViaCompanyName: string;
                export const ShippedDate: string;
            }

            namespace OrdersQry {
                export const Address: string;
                export const City: string;
                export const CompanyName: string;
                export const Country: string;
                export const CustomerId: string;
                export const EmployeeId: string;
                export const Freight: string;
                export const OrderDate: string;
                export const OrderId: string;
                export const PostalCode: string;
                export const Region: string;
                export const RequiredDate: string;
                export const ShipAddress: string;
                export const ShipCity: string;
                export const ShipCountry: string;
                export const ShipName: string;
                export const ShipPostalCode: string;
                export const ShipRegion: string;
                export const ShipVia: string;
                export const ShippedDate: string;
            }

            namespace SalesInvoice {
                export const Date: string;
                export const Notes: string;
                export const SaleInvoiceId: string;
            }

            namespace SalesInvoiceItems {
                export const Date: string;
                export const Id: string;
                export const Notes: string;
                export const SalesInvoiceId: string;
                export const SalesInvoiceNotes: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace Login {
                export const ForgotPassword: string;
                export const LoginToYourAccount: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace SendActivation {
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
        export const SiteTitle: string;
    }

    export declare namespace Navigation {
        export const Dashboard: string;
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace Layout {
            export const Language: string;
            export const Theme: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const SavePrimaryKeyError: string;
    }

    MovieProject['Texts'] = proxyTexts(Texts, '', {
        Db: {
            Administration: {
                Language: {},
                Role: {},
                RolePermission: {},
                Translation: {},
                User: {},
                UserPermission: {},
                UserRole: {}
            },
            MovieDB: {
                Genre: {},
                Movie: {},
                MovieCast: {},
                MovieGenres: {},
                Person: {}
            },
            Northwind: {
                OrderDetails: {},
                OrderDetailsExtended: {},
                OrderSubtotals: {},
                Orders: {},
                OrdersQry: {},
                SalesInvoice: {},
                SalesInvoiceItems: {}
            }
        },
        Forms: {
            Membership: {
                Login: {},
                SendActivation: {},
                SignUp: {}
            }
        },
        Navigation: {},
        Site: {
            AccessDenied: {},
            Layout: {},
            RolePermissionDialog: {},
            UserDialog: {},
            UserPermissionDialog: {},
            ValidationError: {}
        },
        Validation: {}
    }) as any;
}

export const Texts = MovieProject.Texts;