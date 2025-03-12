﻿using Common.Repositories.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
	public interface IBoardgameRepository<TGame> : IInsertRepository<TGame, int>, IGetRepository<TGame,int>
	{
	}
}
