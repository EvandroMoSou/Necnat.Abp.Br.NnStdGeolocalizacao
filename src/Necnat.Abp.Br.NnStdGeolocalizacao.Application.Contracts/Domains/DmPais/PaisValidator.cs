using Microsoft.Extensions.Localization;
using Necnat.Abp.NnLibCommon.Extensions;
using Necnat.Abp.NnLibCommon.Models;
using Necnat.Abp.NnLibCommon.Validators;
using System.Collections.Generic;
using System.Linq;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Domains
{
    public static class PaisValidator
    {
        public static List<string>? Validate(PaisDto dto, IStringLocalizer stringLocalizer)
        {
            var lError = new List<string>();

            lError.AddIfNotIsNullOrWhiteSpace(ValidateNome(dto.Nome, stringLocalizer));
            lError.AddIfNotIsNullOrWhiteSpace(ValidateNomeIngles(dto.NomeIngles, stringLocalizer));
            lError.AddIfNotIsNullOrWhiteSpace(ValidateNomeFrances(dto.NomeFrances, stringLocalizer));
            lError.AddIfNotIsNullOrWhiteSpace(ValidateCodigoIso3166Alpha2(dto.CodigoIso3166Alpha2, stringLocalizer));
            lError.AddIfNotIsNullOrWhiteSpace(ValidateCodigoIso3166Alpha3(dto.CodigoIso3166Alpha3, stringLocalizer));
            lError.AddIfNotIsNullOrWhiteSpace(ValidateCodigoIso3166Numeric(dto.CodigoIso3166Numeric, stringLocalizer));
            lError.AddIfNotIsNullOrWhiteSpace(ValidateInAtivo(dto.InAtivo, stringLocalizer));

            if (lError.Count > 0)
                return lError;

            return null;
        }

        public static string? ValidateNome(string? value, IStringLocalizer stringLocalizer)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Format(stringLocalizer[ValidationMessages.Required], PaisConsts.NomeDisplay);

            if (value.Length < PaisConsts.MinNomeLength || value.Length > PaisConsts.MaxNomeLength)
                return string.Format(stringLocalizer[ValidationMessages.MinMaxLength], PaisConsts.NomeDisplay, PaisConsts.MinNomeLength, PaisConsts.MaxNomeLength);

            return null;
        }

        public static string? ValidateNomeIngles(string? value, IStringLocalizer stringLocalizer)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            if (value.Length < PaisConsts.MinNomeInglesLength || value.Length > PaisConsts.MaxNomeInglesLength)
                return string.Format(stringLocalizer[ValidationMessages.MinMaxLength], PaisConsts.NomeInglesDisplay, PaisConsts.MinNomeInglesLength, PaisConsts.MaxNomeInglesLength);

            return null;
        }

        public static string? ValidateNomeFrances(string? value, IStringLocalizer stringLocalizer)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            if (value.Length < PaisConsts.MinNomeFrancesLength || value.Length > PaisConsts.MaxNomeFrancesLength)
                return string.Format(stringLocalizer[ValidationMessages.MinMaxLength], PaisConsts.NomeFrancesDisplay, PaisConsts.MinNomeFrancesLength, PaisConsts.MaxNomeFrancesLength);

            return null;
        }

        public static string? ValidateCodigoIso3166Alpha2(string? value, IStringLocalizer stringLocalizer)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            if (value.Length != PaisConsts.CodigoIso3166Alpha2Length)
                return string.Format(stringLocalizer[ValidationMessages.Length], PaisConsts.CodigoIso3166Alpha2Display, PaisConsts.CodigoIso3166Alpha2Length);

            return null;
        }

        public static string? ValidateCodigoIso3166Alpha3(string? value, IStringLocalizer stringLocalizer)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            if (value.Length != PaisConsts.CodigoIso3166Alpha3Length)
                return string.Format(stringLocalizer[ValidationMessages.Length], PaisConsts.CodigoIso3166Alpha3Display, PaisConsts.CodigoIso3166Alpha3Length);

            return null;
        }

        public static string? ValidateCodigoIso3166Numeric(string? value, IStringLocalizer stringLocalizer)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            if (value.Length != PaisConsts.CodigoIso3166NumericLength)
                return string.Format(stringLocalizer[ValidationMessages.Length], PaisConsts.CodigoIso3166NumericDisplay, PaisConsts.CodigoIso3166NumericLength);

            if (!value.All(char.IsDigit))
                return string.Format(stringLocalizer[ValidationMessages.Numeric], PaisConsts.CodigoIso3166NumericDisplay);

            return null;
        }

        public static string? ValidateInAtivo(bool? value, IStringLocalizer stringLocalizer)
        {
            if (value == null)
                return string.Format(stringLocalizer[ValidationMessages.Required], PaisConsts.NomeDisplay);

            return null;
        }

        #region ResultRequestDto

        public static GenericSearchModel<PaisResultRequestDto> ValidateGenericSearch(string? value, IStringLocalizer stringLocalizer)
        {
            if (string.IsNullOrWhiteSpace(value))
                return new GenericSearchModel<PaisResultRequestDto>(stringLocalizer[ValidationMessages.GenericSearchField], new PaisResultRequestDto());

            if (value.Length < 2)
                return new GenericSearchModel<PaisResultRequestDto>(stringLocalizer[ValidationMessages.GenericSearchField], new PaisResultRequestDto(), string.Format(stringLocalizer[ValidationMessages.MinLength], stringLocalizer[ValidationMessages.GenericSearchField], 2));

            if (value.Length == 2)
                return new GenericSearchModel<PaisResultRequestDto>(PaisConsts.CodigoIso3166Alpha2Display, new PaisResultRequestDto { CodigoIso3166Alpha2 = value });

            if (value.Length == 3)
            {
                if (value.All(char.IsDigit))
                    return new GenericSearchModel<PaisResultRequestDto>(PaisConsts.CodigoIso3166NumericDisplay, new PaisResultRequestDto { CodigoIso3166Numeric = value });
                else
                    return new GenericSearchModel<PaisResultRequestDto>(PaisConsts.CodigoIso3166Alpha3Display, new PaisResultRequestDto { CodigoIso3166Alpha3 = value });
            }

            return new GenericSearchModel<PaisResultRequestDto>(PaisConsts.NomeDisplay, new PaisResultRequestDto { NomeContains = value });
        }

        public static List<string>? Validate(PaisResultRequestDto resultRequestDto, IStringLocalizer stringLocalizer)
        {
            var lError = new List<string>();

            lError.AddIfNotIsNullOrWhiteSpace(ValidateNomeContains(resultRequestDto.NomeContains, stringLocalizer));
            lError.AddIfNotIsNullOrWhiteSpace(ValidateCodigoIso3166Alpha2(resultRequestDto.CodigoIso3166Alpha2, stringLocalizer));
            lError.AddIfNotIsNullOrWhiteSpace(ValidateCodigoIso3166Alpha3(resultRequestDto.CodigoIso3166Alpha3, stringLocalizer));
            lError.AddIfNotIsNullOrWhiteSpace(ValidateCodigoIso3166Numeric(resultRequestDto.CodigoIso3166Numeric, stringLocalizer));

            if (lError.Count > 0)
                return lError;

            return null;
        }

        public static string? ValidateNomeContains(string? value, IStringLocalizer stringLocalizer)
        {
            if (value == null)
                return null;

            if (value.Length < PaisConsts.MinNomeLength || value.Length > PaisConsts.MaxNomeLength)
                return string.Format(stringLocalizer[ValidationMessages.MinMaxLength], PaisConsts.NomeDisplay, PaisConsts.MinNomeLength, PaisConsts.MaxNomeLength);

            return null;
        }

        #endregion
    }
}
