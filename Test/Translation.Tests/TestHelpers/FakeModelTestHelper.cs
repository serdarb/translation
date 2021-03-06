﻿using Translation.Client.Web.Models.Language;
using Translation.Client.Web.Models.Organization;
using Translation.Client.Web.Models.Project;
using Translation.Client.Web.Models.User;
using Translation.Common.Models.Shared;
using static Translation.Tests.TestHelpers.FakeConstantTestHelper;

namespace Translation.Tests.TestHelpers
{
    public class FakeModelTestHelper
    {
        public static PagingInfo GetFakePagingInfo()
        {
            var pagingInfo = new PagingInfo();
            pagingInfo.Skip = One;
            pagingInfo.Take = Two;
            pagingInfo.LastUid = UidOne;
            pagingInfo.IsAscending = BooleanTrue;
            pagingInfo.TotalItemCount = Ten;
            pagingInfo.Type = PagingInfo.PAGE_NUMBERS;

            return pagingInfo;
        }


        public static PagingInfo GetFakePagingInfoForSelectMany()
        {
            var pagingInfo = new PagingInfo();
            pagingInfo.Skip = One;
            pagingInfo.Take = Two;
            pagingInfo.LastUid = UidOne;
            pagingInfo.IsAscending = BooleanTrue;
            pagingInfo.TotalItemCount = Ten;
            pagingInfo.Type = PagingInfo.PAGE_NUMBERS;

            return pagingInfo;
        }

        public static PagingInfo GetFakePagingInfoForSelectAfter()
        {
            var pagingInfo = new PagingInfo();
            pagingInfo.Skip = Zero;
            pagingInfo.Take = Two;
            pagingInfo.LastUid = UidOne;
            pagingInfo.IsAscending = BooleanTrue;
            pagingInfo.TotalItemCount = Ten;
            pagingInfo.Type = PagingInfo.PAGE_NUMBERS;

            return pagingInfo;
        }

        public static ProjectCreateModel GetOrganizationOneProjectOneCreateModel()
        {
            var model = new ProjectCreateModel();
            model.OrganizationUid = OrganizationOneUid;
            model.Name = OrganizationOneProjectOneName;
            model.Url = HttpsUrl;

            return model;
        }

        public static ProjectEditModel GetOrganizationOneProjectOneEditModel()
        {
            var model = new ProjectEditModel();
            model.OrganizationUid = OrganizationOneUid;
            model.ProjectUid = OrganizationOneProjectOneUid;
            model.Name = OrganizationOneProjectOneName;
            model.Url = HttpsUrl;

            return model;
        }

        public static ProjectCloneModel GetOrganizationOneProjectOneCloneModel()
        {
            var model = new ProjectCloneModel();
            model.OrganizationUid = OrganizationOneUid;
            model.Name = OrganizationOneProjectOneName;
            model.CloningProjectUid = OrganizationOneProjectOneUid;
            model.LabelCount = One;
            model.LabelTranslationCount = Two;
            model.Url = HttpsUrl;

            return model;
        }

        public static LanguageCreateModel GetLanguageOneCreateModel()
        {
            var model = new LanguageCreateModel();
            model.Name = "Language One";
            model.OriginalName = "Language One Original Name";
            model.IsoCode2 = IsoCode2One;
            model.IsoCode3 = IsoCode3One;
            // todo: model.Icon = 

            return model;
        }

        public static LanguageEditModel GetLanguageOneEditModel()
        {
            var model = new LanguageEditModel();
            model.Name = "Language One";
            model.OriginalName = "Language One Original Name";
            model.IsoCode2 = IsoCode2One;
            model.IsoCode3 = IsoCode3One;

            return model;
        }

        public static SignUpModel GetOrganizationOneUserOneSignUpModel()
        {
            var model = new SignUpModel();
            model.OrganizationName = OrganizationOneName;
            model.Email = OrganizationOneUserOneEmail;
            model.FirstName = StringOne;
            model.LastName = StringTwo;
            model.Password = PasswordOne;
            model.IsTermsAccepted = BooleanTrue;

            return model;
        }

        public static LogOnModel GetOrganizationOneUserOneLogOnModel()
        {
            var model = new LogOnModel();
            model.Email = OrganizationOneUserOneEmail;
            model.Password = PasswordOne;

            return model;
        }

        public static DemandPasswordResetModel GetOrganizationOneUserOneDemandPasswordResetModel()
        {
            var model = new DemandPasswordResetModel();
            model.Email = OrganizationOneUserOneEmail;

            return model;
        }


        public static ResetPasswordModel GetOrganizationOneUserOneResetPasswordModel()
        {
            var model = new ResetPasswordModel();
            model.Email = OrganizationOneUserOneEmail;
            model.Password = PasswordOne;

            return model;
        }

        public static ChangePasswordModel GetOrganizationOneUserOneChangePasswordModel()
        {
            var model = new ChangePasswordModel();
            model.NewPassword = PasswordTwo;
            model.ReEnterNewPassword = PasswordTwo;
            model.OldPassword = PasswordOne;
            model.UserUid = OrganizationOneUserOneUid;

            return model;
        }

        public static InviteModel GetOrganizationOneUserOneInviteModel()
        {
            var model = new InviteModel();
            model.OrganizationUid = OrganizationOneUid;
            model.Email = OrganizationOneUserOneEmail;
            model.FirstName = StringOne;
            model.LastName = StringTwo;

            return model;
        }

        public static InviteAcceptModel GetOrganizationOneUserOneInviteAcceptModel()
        {
            var model = new InviteAcceptModel();
            model.Token = UidOne;
            model.Email = OrganizationOneUserOneEmail;
            model.FirstName = StringOne;
            model.LastName = StringTwo;
            model.Password = PasswordTwo;
            model.ReEnterPassword = PasswordTwo;

            return model;
        }

        public static UserEditModel GetOrganizationOneUserOneUserEditModel()
        {
            var model = new UserEditModel();
            model.UserUid = OrganizationOneUserOneUid;
            model.FirstName = StringOne;
            model.LastName = StringTwo;
            model.LanguageUid = UidOne;

            return model;
        }

        public static OrganizationEditModel GetOrganizationOneOrganizationEditModel()
        {
            var model = new OrganizationEditModel();
            model.OrganizationUid = OrganizationOneUid;
            model.Name = OrganizationOneName;

            return model;
        }
    }
}