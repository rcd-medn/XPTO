



using AutoMapper;
using XPTO.DTOs;
using XPTO.Models;

namespace XPTO.Profiles
{
    public class ClientesProfile : Profile
    {
        public ClientesProfile()
        {
            // ============================================================================================================================
            // Mapeia um objeto Cliente do modelo de dominio (Models) para um objeto DTO, que será entregue à API Cliente.
            // ============================================================================================================================
            CreateMap<Cliente, ClienteReadDTO>();
            CreateMap<ClienteCreateDTO, Cliente>();
        }
    }
}
