﻿using Translation.Common.Models.DataTransferObjects;
using Translation.Common.Models.Requests.Admin;
using Translation.Common.Models.Requests.Organization;
using Translation.Common.Models.Shared;
using Translation.Data.Entities.Main;

namespace Translation.Data.Factories
{
    public class OrganizationFactory
    {
        public  Organization CreateEntityFromRequest(SignUpRequest request, string key, string iv)
        {
            var entity = new Organization();

            entity.Name = request.OrganizationName;
            entity.ObfuscationKey = key;
            entity.ObfuscationIv = iv;
            entity.IsActive = true;

            return entity;
        }

        public  Organization CreateEntityFromRequest(OrganizationEditRequest request, Organization entity)
        {
            entity.UpdatedBy = request.CurrentUserId;
            entity.Name = request.Name;
            entity.Description = request.Description;

            return entity;
        }

        public  OrganizationDto CreateDtoFromEntity(Organization entity)
        {
            var dto = new OrganizationDto();
            dto.Uid = entity.Uid;
            dto.Name = entity.Name;
            dto.IsActive = entity.IsActive;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.IsActive = entity.IsActive;

            dto.Description = entity.Description;
            dto.IsActive = entity.IsActive;
            dto.UserCount = entity.UserCount;

            return dto;
        }

        public CurrentOrganization MapCurrentOrganization(Organization platformOrganization)
        {
            var currentOrganization = new CurrentOrganization();
            currentOrganization.Id = platformOrganization.Id;
            currentOrganization.Uid = platformOrganization.Uid;
            currentOrganization.Name = platformOrganization.Name;

            return currentOrganization;
        }

        public Organization MapCurrentOrganization(CurrentOrganization currentOrganization)
        {
            var organizationEntity = new Organization();
            organizationEntity.Id = currentOrganization.Id;
            organizationEntity.Uid = currentOrganization.Uid;
            organizationEntity.Name = currentOrganization.Name;

            return organizationEntity;
        }

        public Organization UpdateEntityForChangeActivation(Organization entity)
        {
            entity.IsActive = !entity.IsActive;
            return entity;
        }
    }
}