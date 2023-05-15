﻿using AutoMapper;
using Levva.Newbies.Intensivo.Data.Interfaces;
using Levva.Newbies.Intensivo.Domain.Models;
using Levva.Newbies.Intensivo.Logic.Dtos;
using Levva.Newbies.Intensivo.Logic.Interfaces;

namespace Levva.Newbies.Intensivo.Logic.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;
        public CategoriaService(ICategoriaRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public void Create(CategoriaDto categoria)
        {
            var _categoria = _mapper.Map<Categoria>(categoria);
            _repository.Create(_categoria);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public CategoriaDto Get(int id)
        {
            var categoria = _mapper.Map<CategoriaDto>(_repository.Get(id));
            return categoria;
        }

        public List<CategoriaDto> GetAll()
        {
            var categorias = _mapper.Map<List<CategoriaDto>>(_repository.GetAll());
            return categorias;
        }

        public void Update(CategoriaDto categoria)
        {
            var _categoria = _mapper.Map<Categoria>(categoria);
            _repository.Update(_categoria);
        }
    }
}